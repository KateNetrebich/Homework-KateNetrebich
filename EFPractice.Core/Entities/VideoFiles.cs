using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Core.Entities
{
    public class VideoFiles
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Duration { get; set; }
    }
}
