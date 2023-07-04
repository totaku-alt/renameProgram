using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RenamerProgram
{
    class Matcher
    {

        public static void matcher(string rootFolderPath, string searchFile, string newFileName)
        {
            // Put all Files that the user is looking for into an array
            string[] files = Directory.GetFiles(rootFolderPath, searchFile);

            if (files.Length > 0)
            {
                Console.WriteLine(searchFile);
                Console.WriteLine("--- Found Files: ---");

                foreach (string names in files)
                {
                    Console.WriteLine(names);
                    Console.WriteLine("test");
                }

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Array ist leer");
                Console.WriteLine("Datei nach der gesucht wurde:" + searchFile);
                return;
            }


            try
            {
                RecursiveFileRename(rootFolderPath, searchFile, newFileName);
                Console.WriteLine("File renaming completed.");
            }
            catch (Exception e)
            {
              
                Console.WriteLine("An error occurred: {0}", e.Message);
                return;
            }
        }




        public static object RecursiveFileRename(string rootFolderPath, string searchFile, string newFileName)
        {
            // Process files in the current folder
            string[] files = Directory.GetFiles(rootFolderPath, searchFile);

            foreach (string filePath in files)
            {
                string newFilePath = Path.Combine(rootFolderPath, newFileName);
                File.Move(filePath, newFilePath);

            }

            // Process subfolders recursively
            string[] subfolders = Directory.GetDirectories(rootFolderPath);
            foreach (string subfolderPath in subfolders)
            {
                if (!subfolderPath.EndsWith("\\test"))
                {
                    RecursiveFileRename(subfolderPath, searchFile, newFileName);
                }
            }
            return files;
        }

        static void runTests()
        {
            Console.WriteLine("Run All Matcher Tests!");

            Console.ReadKey();
            return;

        }
    }
}
