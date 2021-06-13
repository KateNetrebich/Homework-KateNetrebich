using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Core.Entities
{
    public class Directories
    {
        public int Id { get; set; }
        public int ParentDirectoryId { get; set; }
        public string Title { get; set; }
    }
}
