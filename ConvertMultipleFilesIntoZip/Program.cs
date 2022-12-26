using System;
using System.IO;
using System.IO.Compression;

namespace ConvertMultipleFilesIntoZip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("..........Convert multiple files into a zip file...........");
                Console.WriteLine();
                Console.WriteLine();
                string zipPath = @"d:\result" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".zip";

                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                {
                    Console.WriteLine("Enter the 1st file path, Which you want to add: ");
                    string sourcePath1 = Console.ReadLine();
                    Console.WriteLine("Enter the 2st file path, Which you want to add: ");
                    string sourcePath2 = Console.ReadLine();
                    Console.WriteLine("Enter the 3st file path, Which you want to add: ");
                    string sourcePath3 = Console.ReadLine();
                    Console.WriteLine("Enter the 4st file path, Which you want to add: ");
                    string sourcePath4 = Console.ReadLine();
                    archive.CreateEntryFromFile(sourcePath1, "file1.txt");
                    archive.CreateEntryFromFile(sourcePath2, "file2.txt");
                    archive.CreateEntryFromFile(sourcePath3, "file1.txt");
                    archive.CreateEntryFromFile(sourcePath4, "sanju1.nupkg");

                    /*archive.CreateEntryFromFile(@"d:\file1.txt", "file1.txt");
                    archive.CreateEntryFromFile(@"c:\Intel\file2.txt", "file2.txt");
                    archive.CreateEntryFromFile(@"d:\file1.txt", "file1.txt");
                    archive.CreateEntryFromFile(@"d:\sanju1.nupkg", "sanju1.nupkg");*/

                }
                Console.WriteLine("Zip file path is " + zipPath + " .");
            }
            catch (FileNotFoundException dirEx)
            {
                Console.WriteLine("File does not exist: " + dirEx.Message);
            }



        }

    }
} 

