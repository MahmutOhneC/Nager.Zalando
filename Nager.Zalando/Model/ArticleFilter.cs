using System;
using System.Text;

namespace Nager.Zalando.Model
{
    public class ArticleFilter
    {
        public AgeGroup? AgeGroup;
        public Color? Color;
        public Gender? Gender;
        public string FullText;

        public string GetFilter()
        {
            var sb = new StringBuilder();
            
            if (this.AgeGroup != null)
            {
                var ageGroups = this.AgeGroup.ToString().Split(',');
                foreach (var ageGroup in ageGroups)
                {
                    sb.Append($"&ageGroup={ageGroup.Trim()}");
                }
            }

            if (this.Color != null)
            {
                var colors = this.Color.ToString().Split(',');
                foreach (var color in colors)
                {
                    sb.Append($"&color={color.Trim()}");
                }
            }

            if (this.Gender != null)
            {
                var genders = this.Gender.ToString().Split(',');
                foreach (var gender in genders)
                {
                    sb.Append($"&gender={gender.Trim()}");
                }
            }

            if (!string.IsNullOrEmpty(this.FullText))
            {
                sb.Append($"&fulltext={this.FullText}");
            }

            sb.Remove(0, 1);
            sb.Insert(0, "?");

            return sb.ToString();
        }

    }


    [Flags]
    public enum AgeGroup
    {
        Babies = 1,
        Kids = 2,
        Teen = 4,
        Adult = 8,
    }

    [Flags]
    public enum Color
    {
        Black = 1,
        Brown = 2,
        Beige = 4,
        Gray = 8,
        White = 16,
        Blue = 32,
        Petrol = 64,
        Turquoise = 128,
        Green = 256,
        Olive = 512,
        Yellow = 1024,
        Orange = 2048,
        Red = 4096,
        Pink = 8192,
        Purple = 16384,
        Gold = 32768,
        Silver = 65536,
        Multicolored = 131072,
    }

    [Flags]
    public enum Gender
    {
        Male,
        Female,
    }
}
