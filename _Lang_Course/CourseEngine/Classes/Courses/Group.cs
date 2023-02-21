using System;
using _Lang_Course.CourseEngine.Classes.Masterings;

namespace _Lang_Course.CourseEngine.Classes.Courses
{
	public class Group: Course
	{

		public List<Listener> Listeners { get; set; }

		public Group(Mastering Mastering, List<Listener> Listeners): base(Mastering)
		{
			this.Listeners = Listeners;
		}
	}
}

