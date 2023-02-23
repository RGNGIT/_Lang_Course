using System;
using _Lang_Course.CourseEngine.Classes.Masterings;

namespace _Lang_Course.CourseEngine.Classes.Courses
{
	[Serializable]
	public class Course
	{

		public string Name { get; set; }
		public Mastering Mastering { get; set; }

		public Course(Mastering Mastering, string Name)
		{
			this.Name = Name;
			this.Mastering = Mastering;
		}
	}
}

