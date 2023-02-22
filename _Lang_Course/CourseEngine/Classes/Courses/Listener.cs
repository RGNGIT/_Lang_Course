using System;
namespace _Lang_Course.CourseEngine.Classes.Courses
{
	[Serializable]
	public class Listener
	{

		public string FIO { get; set; }
		public bool isOld { get; set; } = false;

		public Listener(string FIO)
		{
			this.FIO = FIO;
		}
	}
}

