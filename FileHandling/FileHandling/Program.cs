using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;
namespace project_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Getting file from current directory
            string path = @"..\..\..\file.txt";

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

           //file information and read all char 

            FileInfo name = new FileInfo(path);//creating a object and with refrence we r accessing nam n ext
            string fileName = name.Name;//file name
            string fileExtension = name.Extension;//file extension
            Console.WriteLine("File name : " + fileName);
            Console.WriteLine("File Extension : " + fileExtension);
          //counting words in the text file
            int wordCount = 1;
            for (int i = 0; i <= readText.Length - 1; i++)
            {
                Console.WriteLine("Length of  the content length: {0}", readText.Length);
                if (readText[i] == ' ' )
                {
                    wordCount++;
                }

                if(!readText.Substring(i+1, readText.Length-(i +1)).Contains(' '))
                {
                    wordCount++;
                    break;
                }
            }
            Console.WriteLine("Total words is : " + wordCount);
           //source to destination
            string sourceFile = @"..\..\..\file.txt";
            string destinationFile = @"D:\test.txt";
           File.Copy(sourceFile, destinationFile, true);
         
            //File.Delete(@"D:\test.txt");

         
        
        }
    }
}















