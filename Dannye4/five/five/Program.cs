using System;
using System.IO;
using System.Text;

namespace ConsoleApplication158
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь: ");
            string dirPath = Console.ReadLine();

            var res = new StringBuilder();
            BuildDirTree(res, dirPath);

            File.WriteAllText(@"D:\Test.txt", res.ToString());
        }

        private static void BuildDirTree(StringBuilder res, string dirPath, int level = 0)
        {
            res.AppendLine(new string(' ', level) + Path.GetFileName(dirPath));
            foreach (var subDir in Directory.GetDirectories(dirPath))
            {
                BuildDirTree(res, subDir, level + 1);
                DirectoryInfo info = new DirectoryInfo(subDir);
                foreach(var file in info.GetFiles())
                {
                    res.AppendLine($" {level} {file.Name}");
                }
            }
        }
        
        
    }
}