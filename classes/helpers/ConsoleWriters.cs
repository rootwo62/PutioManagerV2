﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PutioManager.classes.helpers
{
    class ConsoleWriters
    {
        private void PrintPutioProperties(PutioFile putiofile)
        {
            Console.WriteLine("===================");
            Console.WriteLine("filename: " + putiofile.name);
            Console.WriteLine("fileid: " + putiofile.id);
            Console.WriteLine("parent_id: " + putiofile.parent_id);
            Console.WriteLine("filetype: " + putiofile.file_type);
        }
    }
}
