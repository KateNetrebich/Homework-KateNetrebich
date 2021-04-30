using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class ImageParser : IFileParse
    {
        public IFileInfo Parse(string line)
        {
            var file = line.Split(new Char[] { ':', '(' })[0];
            var size = line.Split(new Char[] { '(', ')' })[1];
            var bytes = ByteSizeLib.ByteSize.Parse(size).Bytes;
            var resolution = line.Split(new Char[] { ';', '\n' })[1];
            return new ImageFile("Image", file, (long)bytes, resolution);
        }
    }
}
