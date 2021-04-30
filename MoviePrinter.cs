using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class MoviePrinter : IFileInfoPrinter
    {
        public void Print(IFileInfo fileInfo, string prefix)
        {
            var movieFile = (MovieFile)fileInfo;
            var name = movieFile.FileName;
            var exten = movieFile.Extention;
            var size = ByteSizeLib.ByteSize.FromBytes(movieFile.Size).ToString();
            var resolution = movieFile.Resolution;
            var length = movieFile.Length;
            Console.WriteLine($"{prefix}{name}\n" +
                $"{prefix}  Extention:{exten}\n" +
                $"{prefix}  Size:{size}\n" +
                $"{prefix}  Resolution:{resolution}\n" +
                $"{prefix}  Length:{length}");
        }
    }
}
