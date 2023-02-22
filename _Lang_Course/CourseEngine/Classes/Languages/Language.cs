using System;
namespace _Lang_Course.CourseEngine.Classes.Languages
{
	[Serializable]
	public class Language
	{

		public int CharAmount { get; set; }
		public float PercentOfSpread { get; set; }

		public Language(int CharAmount, float PercentOfSpread)
		{
			this.CharAmount = CharAmount;
			this.PercentOfSpread = PercentOfSpread;
		}

	}
}

