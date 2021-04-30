using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class FilesPrinter
    {
        IFileInfoPrinter textFilePrinter = new TextPrinter();
        IFileInfoPrinter imageFilePrinter = new ImagePrinter();
        IFileInfoPrinter movieFilePrinter = new MoviePrinter();
        public void Print(List<IFileInfo> files, string prefix)
        {
            
            foreach (var file in files)
            {
                var type = file.Type;
                GetPrinterByType(type).Print(file, prefix);
            }
        }

        private IFileInfoPrinter GetPrinterByType(string type)
        {
            switch (type)
            {
                case "Text":
                    return textFilePrinter;
                case "Image":
                    return imageFilePrinter;
                case "Movie":
                    return movieFilePrinter;

            }
            throw new Exception("Unsupported type");
        }
    }
}
