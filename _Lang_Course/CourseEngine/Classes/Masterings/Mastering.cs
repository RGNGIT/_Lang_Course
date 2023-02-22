using System;
using _Lang_Course.CourseEngine.Classes.Languages;
namespace _Lang_Course.CourseEngine.Classes.Masterings
{
	[Serializable]
	public class Mastering
	{

		public Language Language { get; set; }

		public Mastering(Language Language)
		{
			this.Language = Language;
		}

	}
}

