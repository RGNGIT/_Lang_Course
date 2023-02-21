using System;
using _Lang_Course.CourseEngine.Classes.Masterings;

namespace _Lang_Course.CourseEngine.Classes.Courses
{
	public class Individual: Course
	{

		public Listener Listener { get; set; }

		public Individual(Mastering Mastering, Listener Listener): base(Mastering)
		{
			this.Listener = Listener;
		}
	}
}

