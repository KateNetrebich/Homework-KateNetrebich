using System;
using System.IO;

namespace CSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVConvert csvConvert = new CSVConvert(PersonList.GetListPerson());
            string path = @"D:\CSVFile";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream fstream = new FileStream($@"{path}\CSVFile.csv", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(csvConvert.Export());
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
        }
    }
}
