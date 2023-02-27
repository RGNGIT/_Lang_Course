using System;
using System.CodeDom;
using _Lang_Course.CourseEngine.Classes.Courses;
using _Lang_Course.CourseEngine.Classes.Languages;
using _Lang_Course.CourseEngine.Classes.Masterings;

#pragma warning disable CS8602

namespace _Lang_Course.CourseEngine
{

	public class Storage 
	{
		public List<Course?> Courses { get; set; } = new();
		public List<Listener?> Listeners { get; set; } = new();
		public List<Language?> Languages { get; set; } = new();
		public List<Mastering?> Masterings { get; set; } = new();
	}

	public class CourseEngineCore
	{
		public Storage storage { get; set; }

		public CourseEngineCore(Storage storage)
		{
			this.storage = storage;
		}

		public Listener RegisterNewListener(string FIO)
		{
			Listener listener = new(FIO);
			storage.Listeners.Add(listener);
			return listener;
		}

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
					temp += (course as Individual).Listener.FIO + " (Индивидуальный)";
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

	}
}

