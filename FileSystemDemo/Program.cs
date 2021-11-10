using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\users\opilane\source\repos\logitpe21\File";

            /*string[] dirs = Directory.GetDirectories(rootPath ,"*", SearchOption.AllDirectories);

            foreach(string dir in dirs)
            {
                Console.WriteLine(dir);
            }  */

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            //foreach(string file in files)
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            //}
            //string newPath = @"C:\users\opilane\source\repos\logitpe21\File\SubFolder1";
            //bool directoryExistis = Directory.Exists(@"C:\users\opilane\source\repos\logitpe21\File\SubFolder1");
            //if (directoryExistis)
            //{
            //    Console.WriteLine("directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("directory doesnt exist");
            //    Directory.CreateDirectory(newPath);
            //}
            string[] files = Directory.GetFiles(rootPath);
            string destinationFolder = @"C:\users\opilane\source\repos\logitpe21\File\SubFolder1";
            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder} {Path.GetFileName(file)}", true);
            //}
            for (int i = 0; i < files.Length; i++)
            {
                File.Copy(files[i], $"{destinationFolder} {i}.txt", true);
            }

            Console.ReadLine();
        }
    }
}
