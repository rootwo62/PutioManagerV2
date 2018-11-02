using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Flurl;
using Flurl.Http;

namespace PutioApi
{
    public class Transfers
    {

        private readonly HttpClient httpClient = new HttpClient();
        private const string urlPutioApi = "https://api.put.io/v2/";
        private string oAuthToken;

        public Transfers(string inStrOAuthToken)
        {
            oAuthToken = inStrOAuthToken;
        }

        public async Task<JArray> List()
        {
            var pathsegment = string.Format("transfers/list");
            var query = new[] { "oauth_token=" + oAuthToken };

            string response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .GetStringAsync();
            return (JArray)JObject.Parse(response)["transfers"];
        }

        public async Task<string> Add(string inStrUrl, string inStrParentID)
        {
            string pathsegment = "transfers/add";
            var query = new[] { "oauth_token=" + oAuthToken };
            var post = new { url = inStrUrl, save_parent_id = inStrParentID };

            var response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .PostJsonAsync(post);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<JObject> Get(string instrTransferId)
        {
            var pathsegment = string.Format("transfers/{0}", instrTransferId);
            var query = new[] { "oauth_token=" + oAuthToken };

            string response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .GetStringAsync();
            return (JObject)JObject.Parse(response)["transfer"];
        }

        public async Task<string> Cancel(string inStrParentId)
        {
            string pathsegment = "transfers/cancel";
            var query = new[] { "oauth_token=" + oAuthToken };
            var post = new { transfer_ids = inStrParentId };

            var response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .PostJsonAsync(post);
            return await response.Content.ReadAsStringAsync();
        }

    }
}
