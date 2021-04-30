using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class TextFile : FileInfo
    {
        public TextFile(string type, string fileName, long size, string content) : base(type, fileName, size)
        {
            Content = content;
        }

        public string Content { get; }
    }
}
