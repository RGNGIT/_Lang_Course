using System;
namespace _Lang_Course.CourseEngine.Classes.Languages
{
	[Serializable]
	public class French: Language
	{

		public string Region { get; set; }

		public French(int CharAmount, float PercentOfSpread, string Region): base(CharAmount, PercentOfSpread)
		{
			this.Region = Region;
		}

	}
}

