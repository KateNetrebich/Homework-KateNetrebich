using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class MovieFile : FileInfo
    {
        public MovieFile(string type, string fileName, long size, string resolution, string length) : base(type, fileName, size)
        { 
            Resolution = resolution;
            Length = length;
        }
        public string Resolution { get; }
        public string Length { get; }
    }
}
