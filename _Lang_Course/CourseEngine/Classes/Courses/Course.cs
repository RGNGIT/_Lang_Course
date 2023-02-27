using System;
using _Lang_Course.CourseEngine.Classes.Masterings;

namespace _Lang_Course.CourseEngine.Classes.Courses
{
	[Serializable]
	public class Course
	{

		public string Name { get; set; }
		public float Price { get; set; }
		public Mastering Mastering { get; set; }

		public Course(Mastering Mastering, string Name, float Price)
		{
			this.Name = Name;
			this.Price = Price;
			this.Mastering = Mastering;
		}
	}
}

