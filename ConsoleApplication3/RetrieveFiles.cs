using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication3
{
    public static class RetrieveFiles
    {
        
        public static List<FileInformation> getFileInDirectory(string directory){
            List<FileInformation> fileInfo = new List<FileInformation>();
            
            FileInformation tempFile;
            

            DirectoryInfo di = new DirectoryInfo(directory);
            di.Refresh();

            if (di.Exists)
            {
                FileInfo [] fi = di.GetFiles("*.jpg");
                           
                if (fi.Length > 0)
                {
                    foreach (FileInfo file in fi)
                    {
                        tempFile = new FileInformation();
                        tempFile.FileName = file.Name;
                        tempFile.FileCreateDate = file.LastWriteTime;
                        tempFile.Path = file.DirectoryName;
                        fileInfo.Add(tempFile);
                    }
                }
            }
            return fileInfo;
        }
        

    }
}
