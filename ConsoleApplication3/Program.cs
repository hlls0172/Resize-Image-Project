using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryScanning = "C:\\Users\\Hill\\Pictures\\Liam";
            List<FileInformation> fileInfo = RetrieveFiles.getFileInDirectory(directoryScanning);
            Boolean[] months = new Boolean[12];
            for (int i = 0; i < months.Length; i++)
            {
                months[i] = false;
            }
                

            if (fileInfo != null)
            {
                foreach (FileInformation item in fileInfo)
                {
                    //Console.WriteLine("file name = " + item.FileName + "  Path = " + item.Path + " Creation Date = " + item.FileCreateDate.ToShortDateString());
                    //Console.Write("month listed = " + item.FileCreateDate.Month.ToString() + "\t");
                    //if(item.FileName == "IMG_1641.JPG")
                    //    Console.WriteLine("11th month = " + item.FileCreateDate.Month);
                    if (months[item.FileCreateDate.Month - 1] == false)
                        months[item.FileCreateDate.Month - 1] = true;
                }
                Console.WriteLine("count = " + fileInfo.Count.ToString());
            }
            else
                Console.WriteLine("there isn't anything in here");


            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i].ToString());
            }
            Console.Read();

        }
    }
}
