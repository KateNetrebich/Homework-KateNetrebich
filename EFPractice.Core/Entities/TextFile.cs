using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Core.Entities
{
    public class TextFile
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
