using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Core.Entities
{
    public class Files
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Extension { get; set; }
        public int DirectoryId { get; set; }
    }
}
