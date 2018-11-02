using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Flurl;
using Flurl.Http;

namespace PutioApi
{
    public class Files
    {
        private readonly HttpClient httpClient = new HttpClient();
        private const string urlPutioApi = "https://api.put.io/v2/";
        private string oAuthToken;

        public Files(string inStrOAuthToken)
        {
            oAuthToken = inStrOAuthToken;
        }

        public async Task<JObject> AccountInfo()
        {
            var pathsegment = string.Format("account/info");
            var query = new[] { "oauth_token=" + oAuthToken };

            var response = await urlPutioApi.AppendPathSegment(pathsegment).SetQueryParams(query).GetStringAsync();
            return (JObject)JObject.Parse(response)["info"];
        }

        public async Task<JArray> List(string inStrParentId)
        {
            var pathsegment = string.Format("files/list");
            var query = new[] { "parent_id=" + inStrParentId, "oauth_token=" + oAuthToken };
            var response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .GetStringAsync();
            return (JArray)JObject.Parse(response)["files"];
        }

        public async Task<JObject> Get(string inStrParentId)
        {
            var pathsegment = string.Format("files/{0}", inStrParentId);
            var query = new[] { "oauth_token=" + oAuthToken };

            string response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .GetStringAsync();
            return (JObject)JObject.Parse(response)["file"];
        }

        public async Task<string> Delete(string inStrFileIds)
        {
            string pathsegment = "files/delete";
            var query = new[] { "oauth_token=" + oAuthToken };
            var post = new { file_ids = inStrFileIds };

            var response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .PostJsonAsync(post);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Rename(string inStrFileId, string inStrName)
        {
            string pathsegment = "files/rename";
            var query = new[] { "oauth_token=" + oAuthToken };
            var post = new { file_id = inStrFileId, name = inStrName };

            string CurrentName = (await Get(inStrFileId)).ToString();

            if (inStrName != CurrentName)
            {
                var response = await urlPutioApi.AppendPathSegment(pathsegment)
                    .SetQueryParams(query)
                    .PostJsonAsync(post);
                return await response.Content.ReadAsStringAsync();
            }
            return null;
        }

        public async Task Download(string inStrFileId, string inStrFilePath, string inStrFileName = null)
        {
            var download = await urlPutioApi.AppendPathSegment("files")
                .DownloadFileAsync(inStrFilePath, inStrFileName);
        }

        public async Task<JObject> CreateFolder(string inStrFolderName, string inStrParentId)
        {
            string pathsegment = "files/create-folder";
            var query = new[] { "oauth_token=" + oAuthToken };
            var post = new { name = inStrFolderName, parent_id = inStrParentId };

            var response = await urlPutioApi.AppendPathSegment(pathsegment)
                .SetQueryParams(query)
                .PostJsonAsync(post);

            string postresponse = await response.Content.ReadAsStringAsync();
            return (JObject)JObject.Parse(postresponse)["file"];
        }

    }
}
