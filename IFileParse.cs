using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public interface IFileParse
    {
        IFileInfo Parse(string line);
    }
}
