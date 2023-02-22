using System;
namespace _Lang_Course.CourseEngine.Classes.Languages
{
	[Serializable]
	public class Japanese: Language
	{

		public string GlyphType { get; set; }

		public Japanese(int CharAmount, float PercentOfSpread, string GlyphType): base(CharAmount, PercentOfSpread)
		{
			this.GlyphType = GlyphType;
		}

	}
}

