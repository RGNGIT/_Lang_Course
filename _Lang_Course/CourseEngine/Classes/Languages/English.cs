using System;
namespace _Lang_Course.CourseEngine.Classes.Languages
{
	public class English: Language
	{

		public string SpeakerType { get; set; }

		public English(int CharAmount, float PercentOfSpread, string SpeakerType): base(CharAmount, PercentOfSpread)
		{
			this.SpeakerType = SpeakerType;
		}

	}
}

