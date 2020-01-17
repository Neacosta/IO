using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class file
    {
        public static string filename { get; set; }
        

        public static void setFile(string path)
        {
            filename = path;

        }

        public static string GetFilePath()
        {
            string file = filename;

            return file;
        }



    }
}
