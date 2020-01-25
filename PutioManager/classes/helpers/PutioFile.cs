using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
namespace PutioManager.classes.helpers
{
    public class PutioFile
    {
        public readonly string id;
        public string name;
        public string size;
        public string file_type;
        public string folder_type;
        public string content_type;
        public string parent_id;
        public bool is_hidden;
        public bool is_mp4_available;
        public bool is_shared;

        public string download_path;
        public bool downloaded;
		public bool canceled;
        public Uri downloadlink;
        public DataGridViewRow rowinque;
        public TreeNode file;
        public WebClient webclient;

        public PutioFile(string inStrFileID, string inStrFileName)
        {
            id = inStrFileID;
            name = inStrFileName;
        }


        public PutioFile(JObject file)
        {
            id = file["id"].ToString();
            name = file["name"].ToString();
            parent_id = file["parent_id"].ToString();
            content_type = file["content_type"].ToString();
            file_type = file["file_type"].ToString();
            size = file["size"].ToString();
        }

        protected virtual void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}", name, id, content_type);
        }

    }
}
