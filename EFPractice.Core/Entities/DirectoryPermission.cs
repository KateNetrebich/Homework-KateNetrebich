using System.ComponentModel.DataAnnotations;

namespace EFPractice.Core.Entities
{
    public class DirectoryPermission
    {
        [Key]
        public int DirectoryId { get; set; }
        public int UserId { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
    }
}
