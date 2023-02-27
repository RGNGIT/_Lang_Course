using System;
using _Lang_Course.CourseEngine.Classes.Masterings;

namespace _Lang_Course.CourseEngine.Classes.Courses
{
	[Serializable]
	public class Individual: Course
	{

		public Listener Listener { get; set; }

		public Individual(string Name, Mastering Mastering, Listener Listener, float Price): base(Mastering, Name, Price)
		{
			this.Listener = Listener;
		}
	}
}

