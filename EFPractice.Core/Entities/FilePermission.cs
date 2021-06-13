using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Core.Entities
{
    public class FilePermission
    {
        [Key]
        public int FileId { get; set; }
        public int UserId { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
    }
}
