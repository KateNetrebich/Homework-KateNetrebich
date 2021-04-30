using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP.Task
{
    public class GroupPrinter
    {
        FilesPrinter filesPrinter = new FilesPrinter();
        public void Print(Dictionary<string, List<IFileInfo>> categories)
        {
            
            foreach (var category in categories)
            {
                Console.WriteLine(category.Key);
                filesPrinter.Print(category.Value, "  ");
            }
        }
    }
}
