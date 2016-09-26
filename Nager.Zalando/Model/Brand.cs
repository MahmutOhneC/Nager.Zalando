namespace Nager.Zalando.Model
{
    public class Brand
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string LogoLargeUrl { get; set; }
        public string ShopUrl { get; set; }
        public BrandFamily BrandFamily { get; set; }
    }
}
