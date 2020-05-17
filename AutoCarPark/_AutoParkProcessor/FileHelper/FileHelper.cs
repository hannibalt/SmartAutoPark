using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _AutoParkProcessor.FileHelper
{
   public class FileHelper
    {
        public FileHelper()
        {

        }
       public int CaughtFolder(string PATH)
        {
            string[] files = Directory.GetFiles(PATH);

            return files.Length+1;
        }
    }
}
