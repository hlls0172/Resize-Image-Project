using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace pictureResize
{
    class Program
    {
        static void Main(string[] args)
        {

            Bitmap testImage = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg");
            string testPath = @"C:\Users\Public\Pictures\Sample Pictures\test\Desert.jpg";
            int height = 300;
            int width = 400;

            reSizeImage rsi = new reSizeImage();

            try
            {
                rsi.Save(testImage, width, height, 200, testPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message.ToString());
            }
            

            Console.ReadLine();

        }
    }
}
