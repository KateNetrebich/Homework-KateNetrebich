using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public abstract class FileInfo : IFileInfo
    {

        public FileInfo(string type, string fileName, long size)
        {
            Type = type;
            FileName = fileName;
            Size = size;
        }

        public string FileName { get; }

        public string Extention => FileName.Split(new Char[] { '.' })[1];

        public long Size { get; }

        public string Type { get; }
    }
}
