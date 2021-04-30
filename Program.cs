using System;
using System.Linq;

namespace OOP.Task
{
    class Program
    {
        static void Main(string[] args)
        {

            String text = @"Text:file.txt(6B); Some string content
                Image: img.bmp(19MB);1920х1080
                Text:data.txt(12B);Another string
                Text:data1.txt(7B);Yet another string
                Movie:logan.2017.mkv(19GB);1920х1080;2h12m";

            var filesParser = new FilesParser();
            var files = filesParser.Parse(text);

            var categories = files.GroupBy(f=>f.Type).ToDictionary(category => category.Key, category => category.OrderBy(f=>f.Size).ToList());
            GroupPrinter printer = new GroupPrinter();
            printer.Print(categories);
        }
    }
}
