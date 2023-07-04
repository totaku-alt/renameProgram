using RenamerProgram;
using System;
using System.IO;

namespace Program
{
    class Program
    {

        public static void Main(string[] args)
        {
            int RUN_DEBUG = 0;

            if (RUN_DEBUG == 1)
            {
                //Matcher.runTests();
                //Console.ReadKey();
                //return;
            }

            //Diese Inputs werden im Matcher verwendet

            Console.WriteLine("Input absolute path of your starting folder");
            string rootFolderPath = Console.ReadLine();

            Console.WriteLine("What file are you looking for?");
            Console.WriteLine("Example search: h* -> finds hallo.txt");
            string searchFile = Console.ReadLine();

            Console.WriteLine("What are you renaming it into?");
            Console.WriteLine("Example: Test123.txt");
            string newFileName = Console.ReadLine();


            Matcher.matcher(rootFolderPath, searchFile, newFileName);
        }
    }
}
