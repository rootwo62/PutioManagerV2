using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Flurl;
using Flurl.Http;

namespace PutioApi
{
    public class Zips
    {

        private readonly HttpClient httpClient = new HttpClient();
        private const string urlPutioApi = "https://api.put.io/v2/";
        private string oAuthToken;

        public Zips(string inStrOAuthToken)
        {
            oAuthToken = inStrOAuthToken;
        }

        public async Task<string> CreateZip(string inStrFileIds)
        {
            string pathsegment = "zips/create";
            var query = new[] { "oauth_token=" + oAuthToken };
            var post = new { file_ids = inStrFileIds };

            var response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .PostJsonAsync(post);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<JArray> ListZips()
        {
            var pathsegment = "zips/list";
            var query = new[] { "oauth_token=" + oAuthToken };

            string response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .GetStringAsync();
            return (JArray)JObject.Parse(response)["file"];
        }

        public async Task<JObject> GetZip(string inStrZipID)
        {
            var pathsegment = string.Format("zips/{0}", inStrZipID);
            var query = new[] { "oauth_token=" + oAuthToken };

            string response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .GetStringAsync();
            return JObject.Parse(response);
        }

    }
}
