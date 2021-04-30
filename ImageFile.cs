using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class ImageFile : FileInfo
    {
        public ImageFile(string type, string fileName, long size, string resolution) : base (type, fileName, size)
        {
            Resolution = resolution;
        }
         public string Resolution { get; }
    }
}
