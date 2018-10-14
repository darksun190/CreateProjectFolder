using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateProjectFolder
{
    class CreateFolder
    {
        public static bool createFolder(string path)
        {
            if(Directory.Exists(path))
            {
                return false;
            }
            var di  = Directory.CreateDirectory(path);
            if (di.Exists)
                return true;
            return false;

        }
    }
}
