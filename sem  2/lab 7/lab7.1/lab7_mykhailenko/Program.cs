using System;
using System.IO;

namespace lab7_mykhailenko
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryLink = @".\rootFolder";
            const sbyte FOLDERS_AMOUNT = 100;
            const string FOLDER_NAME = "Folder_";

            DirectoryInfo directory = new DirectoryInfo(directoryLink);
            if(!directory.Exists)
                directory.Create();

            for (int i = 0; i < FOLDERS_AMOUNT; i++)
                directory.CreateSubdirectory(FOLDER_NAME + i);

            Console.WriteLine($"створено  {FOLDERS_AMOUNT} папок, в директорії: {Path.GetFullPath(directoryLink)}\n");
            Console.WriteLine("натисніть любу кнопку, щоб видалити їх...\n");
            Console.ReadKey();

            for (int i = 0; i < FOLDERS_AMOUNT; i++)
                Directory.Delete(directoryLink + @"\" + FOLDER_NAME + i);

            string tempPath = ".";
            sbyte folderCounter = 0;

            for (int i = 0; i < FOLDERS_AMOUNT; i++)
            {
                tempPath += (@"\" + FOLDER_NAME + i);
                try
                {
                    directory.CreateSubdirectory(tempPath);
                    folderCounter++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    break;
                }
            }
            Console.WriteLine($" ");
            Console.WriteLine($"створено {folderCounter} папок, вкладенних одна в одну, в директорії: {Path.GetFullPath(directoryLink)} \n");
            Console.WriteLine("натисніть любу кнопку, щоб видалити їх...\n");
            Console.ReadKey();
            Directory.Delete(directoryLink + @"\" + FOLDER_NAME + 0, true);
            Console.ReadKey();
        }
    }
}
