using System;
using System.IO;
using System.IO.Compression;

namespace ConvertMultipleFilesIntoZip
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            string zipPath = @"d:\result" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".zip";

            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {

                archive.CreateEntryFromFile(@"d:\file3.txt", "file3.txt");
                archive.CreateEntryFromFile(@"d:\file1.txt", "file1.txt");
            }
            Console.WriteLine(zipPath + " is created.");

        }

        
    }
}

