using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nager.Zalando.Model
{
    public class ArticleFilter
    {
        public AgeGroup? AgeGroup;
        public Color? Color;

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
        Black,
        Brown,
        Beige,
        Gray,
        White,
        Blue,
        Petrol,
    }
}
