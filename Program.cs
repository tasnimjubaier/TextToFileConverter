using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToFileConverter
{
    class Program
    {
        private static int progressLines = 10;
        private static int totalLines = 10000;

        private static int _progress;
        public static int Progress
        {
            get { return _progress; }
            set
            {
                if(value != _progress)
                {
                    string[] stars = new string[_progress];
                    Array.Fill<string>(stars, "*");
                    string[] dots = new string[progressLines - _progress];
                    Array.Fill<string>(dots, ".");
                    int percentage = (_progress * 100 / progressLines);
                    var progressMessage = "(\t" + string.Join("", stars) + string.Join("", dots) + "\t)\t" + percentage.ToString() + "%";

                    Console.WriteLine(progressMessage);
                }
                _progress = value;
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter File path : ");
            var path = Console.ReadLine();
            Console.WriteLine("Enter an Empty Folder path : ");
            var rootPath = Console.ReadLine();
            if (path == "") path = @"D:\row_data.txt";
            if (rootPath == "") rootPath = @"D:\Generate";

            if (Directory.Exists(rootPath))
            {
                DeleteDirectory(rootPath);
            }

            Directory.CreateDirectory(rootPath);

            Console.WriteLine("Please wait while your file is being created...");
            var lines = File.ReadAllLines(path);
            var currentLine = 1;

            File.WriteAllText(@"D:\gen.txt", "");
            foreach (var line in lines.Take(10000))
            {
                Progress = currentLine / (totalLines / progressLines);
                var parts = line.Trim().Split(" ");
                if (parts.Length >= 2)
                {
                    File.WriteAllText(rootPath + "\\" + GetFileName(currentLine) + ".txt", string.Join(' ', parts.Skip(1)));
                }
                File.AppendAllText(@"D:\gen.txt", string.Join(' ', parts) + "\n");
                currentLine++;
            }

            Console.WriteLine("Your folder is ready.");
        }
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        public static string GetFileName(int lineNumber)
        {
            return lineNumber.ToString().PadLeft(5, '0');
        }
    }
}
