using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class MovieParser : IFileParse
    {
        public IFileInfo Parse(string line)
        {
            var file = line.Split(new Char[] { ':', '(' })[0];
            var size = line.Split(new Char[] { '(', ')' })[1];
            var bytes = ByteSizeLib.ByteSize.Parse(size).Bytes;
            var resolution = line.Split(new Char[] { ';', ';' })[1];
            var length = line.Split(new Char[] { ';', '\r'})[1];
            return new MovieFile("Movie", file, (long)bytes, resolution, length);
        }
    }
}
