using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class TextPrinter : IFileInfoPrinter
    {
        public void Print(IFileInfo fileInfo, string prefix)
        {
            var textFile = (TextFile)fileInfo;
            var name = textFile.FileName;
            var exten = textFile.Extention;
            var size = ByteSizeLib.ByteSize.FromBytes(textFile.Size).ToString();
            var content = textFile.Content;
            Console.WriteLine($"{prefix}{name}\n" +
                $"{prefix}  Extention:{exten}\n" +
                $"{prefix}  Size:{size}\n" +
                $"{prefix}  Content:{content}");
        }
    }
}
