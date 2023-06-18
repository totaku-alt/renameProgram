using System;
using System.IO;

namespace Renamer
{
    class Program
    {
        public static void Main(string[] args)
        {
            int RUN_DEBUG = 0;

            if (RUN_DEBUG == 1)
            {
                runTests();
                Console.ReadKey();
                return;
            }
            //Harcoded
            //string rootFolderPath = @"C:\test";
            //string targetFileName = "test.txt";
            //string newFileName = "simple.txt";

            //User Input
            Console.WriteLine("Input absolute path of your starting folder");
            string rootFolderPath = Console.ReadLine();
            Console.WriteLine("Input the filename to be changed, together with the filename extension. E.g. (input.txt)");
            string targetFileName = Console.ReadLine();
            Console.WriteLine("Input the new filename together with the filename extension. E.g. (output.txt)");
            string newFileName = Console.ReadLine();

            try
            {
                RecursiveFileRename(rootFolderPath, targetFileName, newFileName);
                Console.WriteLine("File renaming completed.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: {0}", e.Message);
            }
        }

        static void RecursiveFileRename(string folderPath, string targetFileName, string newFileName)
        {
            // Process files in the current folder
            string[] files = Directory.GetFiles(folderPath, targetFileName);
            foreach (string filePath in files)
            {
                string newFilePath = Path.Combine(folderPath, newFileName);
                File.Move(filePath, newFilePath);
                Console.WriteLine("{0} was renamed to {1}.", filePath, newFilePath);
            }

            // Process subfolders recursively
            string[] subfolders = Directory.GetDirectories(folderPath);
            foreach (string subfolderPath in subfolders)
            {
                if (!subfolderPath.EndsWith("\\test"))
                {
                    RecursiveFileRename(subfolderPath, targetFileName, newFileName);
                }
            }
        }

        static void runTests()
        {
            Console.WriteLine("Run All Matcher Tests!");

            Console.ReadKey();
            return;

        }
    }
}
//class Matcher
//{
//static string VERSION = "V1.0";

//public static List matcher(string oldName, string newName, files)
//{
//ToDo: rename files in here...

// return files;
//}
//}
