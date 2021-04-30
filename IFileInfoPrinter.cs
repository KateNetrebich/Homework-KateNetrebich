using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public interface IFileInfoPrinter
    {
        void Print(IFileInfo fileInfo, string prefix);
    }
}
