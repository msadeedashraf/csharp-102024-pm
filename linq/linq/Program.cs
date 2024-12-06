using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string startFolder = "D:\\CBC\\SEProject\\PM\\csharp\\code\\csharp-102024-pm\\linq\\linq\\files";
            // Or
            //string startFolder = "/";

            DirectoryInfo dir = new DirectoryInfo(startFolder);
            var fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

            var fileQuery = from file in fileList
                            where file.Extension == ".txt"
                            orderby file.Name
                            select file;

            // Uncomment this block to see the full query
            // foreach (FileInfo fi in fileQuery)
            // {
            //    Console.WriteLine(fi.FullName);
            // }

            var newestFile = (from file in fileQuery
                              orderby file.CreationTime
                              select new { file.FullName, file.CreationTime })
                              .Last();

            Console.WriteLine($"\r\nThe newest .txt file is {newestFile.FullName}. Creation time: {newestFile.CreationTime}");
            */

            //How to query for duplicate files in a directory tree 

            string startFolder = "D:\\CBC\\SEProject\\PM\\csharp\\code\\csharp-102024-pm\\linq\\linq\\files";

            // Or
            // string startFolder = "/usr/local/share/dotnet/sdk";

            DirectoryInfo dir = new DirectoryInfo(startFolder);

            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

            // used in WriteLine to keep the lines shorter
            int charsToSkip = startFolder.Length;

            // var can be used for convenience with groups.
            var queryDupNames = from file in fileList
                                group file.FullName.Substring(charsToSkip) by file.Name into fileGroup
                                where fileGroup.Count() > 1
                                select fileGroup;

            foreach (var queryDup in queryDupNames.Take(20))
            {
                Console.WriteLine($"Filename = {(queryDup.Key.ToString() == string.Empty ? "[none]" : queryDup.Key.ToString())}");

                foreach (var fileName in queryDup.Take(10))
                {
                    Console.WriteLine($"\t{fileName}");
                }
            }

            Console.ReadKey();
        }
    }
}
