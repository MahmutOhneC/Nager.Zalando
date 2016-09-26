using Nager.Zalando.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nager.Zalando
{
    public class ZalandoWrapper
    {
        private string _language;

        public ZalandoWrapper()
        {
            this.SetLanguage(CultureInfo.CurrentCulture);
        }

        public ZalandoWrapper(CultureInfo cultureInfo)
        {
            this.SetLanguage(cultureInfo);
        }

        private void SetLanguage(CultureInfo cultureInfo)
        {
            this._language = cultureInfo.Name;
        }

        public async Task<RequestInfo> GetArticles(ArticleFilter articleFilter)
        {
            using (var httpClient = new HttpClient())
            {
                var query = articleFilter.GetFilter();

                httpClient.DefaultRequestHeaders.Add("Accept-Language", this._language);
                var httpResponseMessage = await httpClient.GetAsync($"https://api.zalando.com/articles{query}");
                var json = await httpResponseMessage.Content.ReadAsStringAsync();

                var requestInfo = JsonConvert.DeserializeObject<RequestInfo>(json);
                return requestInfo;
            }
        }
    }
}
