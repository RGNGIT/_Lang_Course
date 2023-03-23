using _Lang_Course.CourseEngine.Classes.Courses;
using _Lang_Course.CourseEngine.Classes.Languages;
using _Lang_Course.CourseEngine.Classes.Masterings;
using Microsoft.VisualBasic.Devices;
using System.Runtime.CompilerServices;

#pragma warning disable CS8602

namespace _Lang_Course.CourseEngine
{

	public class Storage 
	{
		public int IterationId { get; set; }
		public List<Course?> Courses { get; set; } = new();
		public List<Listener?> Listeners { get; set; } = new();
		public List<Language?> Languages { get; set; } = new();
		public List<Mastering?> Masterings { get; set; } = new();
	}

	public class ModelEngine
	{

		CourseEngineCore courseEngine;

		public ModelEngine(CourseEngineCore courseEngine) 
		{
			this.courseEngine = courseEngine;
		}

        bool Check2WeekComplete()
        {
            return day % 14 == 0;
        }

        int day { get; set; }
		// Это нам нада
		public List<string> DailyReport(int day)
		{
			this.day = day;
            List<string> temp = new()
            {
                $"День {day}. "
            };
            if (!Check2WeekComplete())
			{
				temp.Add("Новостей нет, все идет своим чередом, кроме того, что все прокачались!");
				return temp;
			}
			else
			{
                RunEvents().ForEach(runResult =>
                {
                    temp.Add(runResult);
                });
				return temp;
            }
		}

		List<string> RunEvents()
		{
            List<string> temp = new()
            {
                "Прошло очередные две недели."
            };
            // Событие повышения студентов
            List<string> listenerRaise = CheckStudentsToRaise();
			if(listenerRaise.Count > 0) 
			{
				listenerRaise.ForEach(raiseResult =>
				{
					temp.Add(raiseResult);
				});
			} 
			else
			{
				temp.Add("Никаких студентов не повысили :( Пустой зал слушателей");
			}
			return temp;
		}

        Course? FetchHigherCourse(Course current)
        {
			Dictionary<string, int> masteringsCompare = new()
			{
				{ "Beginner", 0 },
                { "Middle", 1 },
                { "Expert", 2 },
            };
			// Попытаться найти публичный курс уровнем выше
			foreach(Course? course in courseEngine.storage.Courses) 
			{
				if
				(
				    course.GetType().Name == "Group" &&
					current.Mastering.Language == course.Mastering.Language && 
					masteringsCompare[course.Mastering.GetType().Name] == (masteringsCompare[current.Mastering.GetType().Name] + 1)
				)
				{
					return course;
				}
			}
			// Если не нашли ищем индивидуалочек
			foreach(Course? course in courseEngine.storage.Courses)
			{
				if
				(
				    course.GetType().Name == "Individual" &&
					((Individual)course).Listener == null &&
					current.Mastering.Language == course.Mastering.Language && 
					masteringsCompare[course.Mastering.GetType().Name] == (masteringsCompare[current.Mastering.GetType().Name] + 1)
				)
				{
					return course;
				}
			}
			return null;
        }

		Course? FetchIncluded(Listener listener)
		{
			foreach(Course? course in courseEngine.storage.Courses)
			{
				switch(course.GetType().Name)
				{
					case "Group":
						foreach(Listener groupListener in ((Group)course).Listeners)
						{
							if(listener.Id == groupListener.Id)
							{
								return course;
							}
						}
						return null;
					case "Individual":
						if(listener.Id == ((Individual)course).Listener.Id)
						{
							return course;
						}
						return null;
				}
			}
			return null;
		}

		string? ReassignListener(Listener listener, Course courseFrom, Course courseTo)
		{
            switch (courseFrom.GetType().Name)
			{
				case "Group":
                    ((Group)courseFrom).Listeners.Remove(listener);
                    break;
                case "Individual":
                    ((Individual)courseFrom).Listener = null;
                    break;
            }
			switch (courseTo.GetType().Name) 
			{
                case "Group":
                    ((Group)courseTo).Listeners.Add(listener);
					return "групповой";
                case "Individual":
                    ((Individual)courseTo).Listener = listener;
                    return "индивидуальный";
            }
			return null;
        }

        List<string> CheckStudentsToRaise()
		{
			List<string> temp = new List<string>();
			foreach (Listener? listener in courseEngine.storage.Listeners)
			{
				Course? currentCourse = FetchIncluded(listener!);
				if (currentCourse == null)
				{
					temp.Add($"Студент {listener.FIO} не назначен ни на какие курсы. Пропускаем...");
					continue;
				}
				Course? newCourse = FetchHigherCourse(currentCourse);
				if(newCourse == null)
				{
                    temp.Add($"Студент {listener.FIO} не может быть определен ни на курс выше, ни на индивидуальное (отсутствуют). Пропускаем...");
                    continue;
                }
                temp.Add($"Студент {listener.FIO} получил новый {ReassignListener(listener!, currentCourse, newCourse)} курс классом выше.");
            }
			return temp;
        }

	}

	public class CourseEngineCore
	{
		public Storage storage { get; set; }

		public CourseEngineCore(Storage storage)
		{
			this.storage = storage;
		}
		/*
		public Listener RegisterNewListener(string FIO)
		{
			Listener listener = new(FIO);
			storage.Listeners.Add(listener);
			return listener;
		}
		*/
		public string? DefineMastering(Mastering mastering)
		{
			switch (mastering.GetType().Name)
			{
				case "Beginner": return "Начальный";
				case "Middle": return "Средний";
				case "Expert": return "Продвинутый";
			}
			return null;
		}

		public string? DefineLang(Language language)
		{
			switch (language.GetType().Name)
			{
				case "English":
					return $"Английский. Тип носителя: {(language as English).SpeakerType}";
				case "Japanese":
					return $"Японский. Тип иероглифов: {(language as Japanese).GlyphType}";
				case "German":
					return $"Немецкий. Диалект: {(language as German).Dialect}";
				case "French":
					return $"Французский. Регион: {(language as French).Region}";
			}
			return null;
		}

		public T RegisterNewLanguage<T>(T Language)
		{
			switch (Language!.GetType().Name)
			{
				case "English":
					storage.Languages.Add(Language as English);
					break;
				case "Japanese":
					storage.Languages.Add(Language as Japanese);
					break;
				case "German":
					storage.Languages.Add(Language as German);
					break;
				case "French":
					storage.Languages.Add(Language as French);
					break;
			}
			return Language;
		}

		public T RegisterNewMastering<T>(T Mastering, Language Language)
		{
			(Mastering as Mastering).Language = Language;
			switch (Mastering.GetType().Name)
			{
				case "Beginner":
					storage.Masterings.Add(Mastering as Beginner);
					break;
				case "Middle":
					storage.Masterings.Add(Mastering as Middle);
					break;
				case "Expert":
					storage.Masterings.Add(Mastering as Expert);
					break;
			}
			return Mastering;
		}

		public string StringifyListOfListeners(Course course)
		{
			string temp = "";
			switch (course.GetType().Name)
			{
				case "Individual":
					if((course as Individual).Listener != null)
					{
                        temp += (course as Individual).Listener.FIO + " (Индивидуальный)";
                    }
					else
					{
						temp += "Пусто";
					}
					break;
				case "Group":
					foreach (Listener listener in (course as Group).Listeners)
					{
						temp += listener.FIO + ", ";
					}
					break;
			}
			return temp;
		}

		public List<Listener> CompileListeners(int[] indexes)
		{
			List<Listener> listeners = new List<Listener>();
			for(int i = 0; i < indexes.Length; i++) 
			{
				storage.Listeners[indexes[i]]!.isOld = true;
                listeners.Add(storage.Listeners[indexes[i]]!);
			}
			return listeners;
		}

		public void Write(string? filename)
		{
			Serializer serializer = new();
            if(filename != null) 
			{
				serializer.Save(storage, filename);

            }
			else 
			{
				serializer.Save(storage);
            }
		}

		public void Read(ref List<string> logs, string? filename)
		{
            Serializer serializer = new();
            if (filename != null)
            {
                storage = serializer.Read(ref logs, filename);
            }
            else
            {
                storage = serializer.Read(ref logs);
            }
		}

		public List<string> RunModelEngine(int day) => new ModelEngine(this).DailyReport(day);

	}
}

