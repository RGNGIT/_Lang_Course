using System;
namespace _Lang_Course.CourseEngine.Classes.Courses
{
	[Serializable]
	public class Listener
	{

		public int Id { get; set; }
		public string FIO { get; set; }
		public bool isOld { get; set; } = false;

		public Listener(int Id, string FIO)
		{
			this.Id = Id;
			this.FIO = FIO;
		}
	}
}

