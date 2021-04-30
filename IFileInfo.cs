using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public interface IFileInfo
    {
        string Type { get; }
        string FileName { get; }
        string Extention { get; }
        long Size { get; }


    }
}
