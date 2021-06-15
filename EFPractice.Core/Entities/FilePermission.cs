using System.ComponentModel.DataAnnotations;

namespace EFPractice.Core.Entities
{
    public class FilePermission
    {
        public int FileId { get; set; }
        public int UserId { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }

        public File File { get; set; }
        public User User { get; set; }
    }
}
