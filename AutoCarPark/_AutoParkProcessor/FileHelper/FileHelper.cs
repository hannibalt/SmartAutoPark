using System.IO;

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

            return files.Length + 1;
        }
    }
}
