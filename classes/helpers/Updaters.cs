﻿using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Diagnostics;
using PutioApi;

namespace PutioManager.classes.helpers
{
    class Updaters
    {
        public void UpdateTreeView(JArray inJArrFiles, TreeNode node)
        {
            if (node.Nodes.Count > 0)
                node.Nodes.Clear();
            foreach (JObject file in inJArrFiles)
            {
                string message = null;
                
                var putiofile = new PutioFile(file["id"].ToString(), file["name"].ToString());
                putiofile.parent_id = file["parent_id"].ToString();
                putiofile.content_type = file["content_type"].ToString();
                putiofile.file_type = file["file_type"].ToString();
                //PrintPutioProperties(putiofile);
                TreeNode newnode = node.Nodes.Add(putiofile.name);
                newnode.Tag = putiofile;
                putiofile.file = newnode;

                // set tooltip node text to the files properties
                foreach (var property in file)
                    message += property.Key.ToString().ToLower() + ": " + property.Value.ToString().ToLower() + Environment.NewLine;

                newnode.ToolTipText = message;

                if (file["file_type"].ToString() != "FOLDER")
                {
                    newnode.SelectedImageIndex = 1;
                    newnode.ImageIndex = 1;
                }
                else
                    newnode.Nodes.Add("Loading...");

            }
        }
    }
}
