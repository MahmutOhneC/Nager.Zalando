using System.Collections.Generic;

namespace Nager.Zalando.Model
{
    public class Article
    {
        public string Id { get; set; }
        public string ModelId { get; set; }
        public string Name { get; set; }
        public string ShopUrl { get; set; }
        public string Color { get; set; }
        public bool Available { get; set; }
        public string Season { get; set; }
        public string SeasonYear { get; set; }
        public string ActivationDate { get; set; }
        public List<string> AdditionalInfos { get; set; }
        public List<string> Genders { get; set; }
        public List<string> AgeGroups { get; set; }
        public Brand Brand { get; set; }
        public List<string> CategoryKeys { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Unit> Units { get; set; }
        public Media Media { get; set; }
    }
}
