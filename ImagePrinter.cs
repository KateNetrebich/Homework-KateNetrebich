using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class ImagePrinter : IFileInfoPrinter
    {
        public void Print(IFileInfo fileInfo, string prefix)
        {
            var imageFile = (ImageFile)fileInfo;
            var name = imageFile.FileName;
            var exten = imageFile.Extention;
            var size = ByteSizeLib.ByteSize.FromBytes(imageFile.Size).ToString();
            var resolution = imageFile.Resolution;
            Console.WriteLine($"{prefix}{name}\n" +
                $"{prefix}  Extention:{exten}\n" +
                $"{prefix}  Size:{size}\n" +
                $"{prefix}  Resolution:{resolution}");
        }
    }
}
