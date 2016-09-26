using System.Collections.Generic;

namespace Nager.Zalando.Model
{
    public class RequestInfo
    {
        public List<Article> Content { get; set; }
        public int TotalElements { get; set; }
        public int TotalPages { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
