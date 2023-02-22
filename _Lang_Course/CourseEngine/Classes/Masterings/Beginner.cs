using System;
using _Lang_Course.CourseEngine.Classes.Languages;
namespace _Lang_Course.CourseEngine.Classes.Masterings
{
	[Serializable]
	public class Beginner: Mastering
	{
		public Beginner(Language Language): base(Language)
		{
		}
	}
}

