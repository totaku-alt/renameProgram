using System;
using System.IO;
namespace Renamer
{
    class Program
    {
       public static void Main(string[] args)
    {
         int RUN_DEBUG = 0;

            if(RUN_DEBUG == 1)
            {
                runTests();
                Console.ReadKey();
                return;
            }
        //change to Console.ReadLine() or with args
        string oldFileName = @"c:\test\testfile1.txt";
        string newFileName = @"c:\test\newcoolfilefrombobby.txt";
        try
        {
            if (!File.Exists(oldFileName))
            {
                // This statement ensures that the file is created,
                // but the handle is not kept.
                using (FileStream fs = File.Create(oldFileName)) {}
            }

            // Ensure that the target does not exist.
            if (File.Exists(newFileName))	
            File.Delete(newFileName);

            // Move the file.
            File.Move(oldFileName, newFileName);
            Console.WriteLine("{0} was moved to {1}.", oldFileName, newFileName);

            // See if the original exists now.
            if (File.Exists(oldFileName))
            {
                Console.WriteLine("The original file still exists, which is unexpected.");
            }
            else
            {
                Console.WriteLine("The original file no longer exists, which is expected.");
            }			
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
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
