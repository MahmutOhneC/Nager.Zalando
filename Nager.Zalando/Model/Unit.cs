namespace Nager.Zalando.Model
{
    public class Unit
    {
        public string Id { get; set; }
        public string Size { get; set; }
        public Price Price { get; set; }
        public Price OriginalPrice { get; set; }
        public bool Available { get; set; }
        public int Stock { get; set; }
    }
}
