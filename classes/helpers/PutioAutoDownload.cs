using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutioManager.classes.helpers
{
    class PutioAutoDownload
    {
        public readonly string folder_name;
        public readonly string folder_id;
        public readonly string download_path;
        public readonly int min_download_size;
        public readonly string allowed_extensions;
        public readonly bool keep_folder_structure;

        public PutioAutoDownload(string inFolderName, string inFolderId, string inDownloadPath, int inMinDownloadSize, string inAllowedExtensions, bool inKeepFolderStructure)
        {
            folder_name = inFolderName;
            folder_id = inFolderId;
            download_path = inDownloadPath;
            min_download_size = inMinDownloadSize;
            allowed_extensions = inAllowedExtensions;
            keep_folder_structure = inKeepFolderStructure;
        }
    }
}
