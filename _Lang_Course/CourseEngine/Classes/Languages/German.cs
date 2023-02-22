using System;
namespace _Lang_Course.CourseEngine.Classes.Languages
{
	[Serializable]
	public class German: Language
	{

		public string Dialect { get; set; }

		public German(int CharAmount, float PercentOfSpread, string Dialect) : base(CharAmount, PercentOfSpread)
        {
			this.Dialect = Dialect;
		}

	}
}

