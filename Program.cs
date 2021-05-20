using System;
using System.IO;

namespace FilePractice1
{
    class Program
    {
        private const string NoAccessMessage = "No access.";
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose action");
                Console.WriteLine("1.All");
                Console.WriteLine("2.Folder");
                Console.WriteLine("3.Exit");
                Console.WriteLine();

                var action = Console.ReadLine();
                switch(action)
                {
                    case "1":
                        GetContent(@"C:\Windows");
                        break;
                    case "2":
                        var folderName = Console.ReadLine();
                        ToFolder($"C:\\Windows\\{folderName}");
                        break;
                    case "3":
                        Exit();
                        break;
                }
            }
            
            
        }

        public static void GetContent(string path)
        {
            string[] directories;
            string[] files;

            try
            {
                directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                files = Directory.GetFiles(path);

                if (directories.Length > 0)
                {
                    Console.WriteLine(string.Join("\n", directories));
                }

                if (files.Length > 0)
                {
                    Console.WriteLine(string.Join("\n", files));
                }
            }
            catch
            {
                Console.WriteLine(NoAccessMessage);
            }
        }

        public static void ToFolder(string path)
        {
            try
            {
                var files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
                if (File.Exists(path))
                {
                    foreach (var file in files)
                    {
                        if (files.Length > 0)
                        {
                            Console.WriteLine(string.Join("\n", file));
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine(NoAccessMessage);
            }
        }

        public static void Exit()
        {
            Console.WriteLine("Input exit");
            var exit = Console.ReadLine();
            if(exit == "exit")
            {
                return;
            }
        }
    }
}
