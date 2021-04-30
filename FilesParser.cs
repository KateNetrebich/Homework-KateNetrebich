using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Task
{
    public class FilesParser 
    {
        IFileParse textParser = new TextParser();
        IFileParse imageParser = new ImageParser();
        IFileParse movieParser = new MovieParser();

        public List<IFileInfo> Parse(String text)
        {
            
            var lines = text.Split(new Char[] { '\n' });

            List<IFileInfo> result = new List<IFileInfo>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                var parts = line.Split(new Char[] { ':' });
                var type = parts[0];
                var other = parts[1];
                var parser = GetParseByCategory(type).Parse(other);
                result.Add(parser);
            }
            return result;
        }

        private IFileParse GetParseByCategory( string type)
        {
            switch(type)
            {
                case "Text":
                    return textParser;
                case "Image":
                    return imageParser;
                case "Movie":
                    return movieParser;
            }
            throw new Exception("Unsupported type");
        }
    }
}
