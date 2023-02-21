using System;
using _Lang_Course.CourseEngine.Classes.Masterings;

namespace _Lang_Course.CourseEngine.Classes.Courses
{
	public class Course
	{

		public Mastering Mastering { get; set; }

		public Course(Mastering Mastering)
		{
			this.Mastering = Mastering;
		}
	}
}

