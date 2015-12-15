using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14Lab
{
    class FileClient
    {
        static void Main(string[] args)
        {
            string directoryName = "";
            string fileName = "";
            string input = "";
            string input2 = "";
            const string path = ""; //Put in any directory to search a folder and/or file
            string[] listOfFiles;
            while (input != "end")
            {
                Write("Enter a folder: ");
                input = ReadLine();
                directoryName = path + input;
                if (Directory.Exists(directoryName))
                {
                    WriteLine("Directory exists, and contains the following: ");
                    listOfFiles = Directory.GetFiles(directoryName);
                    for (int x = 0; x < listOfFiles.Length; x++)
                        WriteLine("   {0}", listOfFiles[x]);
                    Write("\nEnter a file name: ");
                    input2 = ReadLine();
                    fileName = directoryName + "\\" + input2;
                    if (File.Exists(fileName))
                    {
                        WriteLine("This file exists");
                        WriteLine("It was created on {0}\n", File.GetCreationTime(fileName));
                    }
                    else
                    {
                        WriteLine("File does not exist\n");
                    }
                }
                else if (input == "end")
                {
                    WriteLine("Goodbye\n");
                }
                else
                {
                    WriteLine("Directory does not exist\n");
                }
            }
        }
    }
}
