using System.ComponentModel.DataAnnotations;

namespace EFPractice.Core.Entities
{
    public class DirectoryPermission
    {
        public int DirectoryId { get; set; }
        public int UserId { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }

        public Directory Directory { get; set; }
        public User User { get; set; }
    }
}
