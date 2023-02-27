using System;
using _Lang_Course.CourseEngine.Classes.Masterings;

namespace _Lang_Course.CourseEngine.Classes.Courses
{
	[Serializable]
	public class Group: Course
	{

		public List<Listener> Listeners { get; set; }

		public Group(string Name, Mastering Mastering, List<Listener> Listeners, float Price): base(Mastering, Name, Price)
		{
			this.Listeners = Listeners;
		}
	}
}

