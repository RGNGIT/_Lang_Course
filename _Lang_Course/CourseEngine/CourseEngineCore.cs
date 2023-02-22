using System;
using _Lang_Course.CourseEngine.Classes.Courses;
using _Lang_Course.CourseEngine.Classes.Languages;
using _Lang_Course.CourseEngine.Classes.Masterings;

#pragma warning disable CS8602

namespace _Lang_Course.CourseEngine
{
	[Serializable]
	public class Storage 
	{
		public List<Course?> Courses { get; set; } = new();
		public List<Listener?> Listeners { get; set; } = new();
		public List<Language?> Languages { get; set; } = new();
		public List<Mastering?> Masterings { get; set; } = new();
	}

	public class CourseEngineCore
	{
		public Storage storage {get; set;}

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

		public T RegisterNewLanguage<T>(T Language, Dictionary<string, string> Values) 
		{
			
			(Language as Language).CharAmount = Convert.ToInt32(Values["CharAmount"]);
			(Language as Language).PercentOfSpread = Convert.ToSingle(Values["PercentOfSpread"]);
			switch(Language!.GetType().Name) 
			{
				case "English": 
				(Language as English).SpeakerType = Values["SpeakerType"];
				storage.Languages.Add(Language as English);
				break;
				case "Japanese":
				(Language as Japanese).GlyphType = Values["GlyphType "];
				storage.Languages.Add(Language as Japanese);
				break;
				case "German":
				(Language as German).Dialect = Values["Dialect"];
				storage.Languages.Add(Language as German);
				break;
				case "French":
				(Language as French).Region = Values["Region"];
				storage.Languages.Add(Language as French);
				break;
			}
			return Language;
		}

		public T RegisterNewMastering<T>(T Mastering, Language Language) 
		{
			(Mastering as Mastering).Language = Language;
			switch(Mastering.GetType().Name) 
			{
				case "Beginner":
				break;
				case "Middle":
				break;
				case "Expert":
				break;
			}
			return Mastering;
		}

	}
}

