using System.Collections.Generic;

namespace EFPractice.Core.Entities
{
    public abstract class File : Entity
    {
        public string Title { get; set; }
        public string Extension { get; set; }
        public int? DirectoryId { get; set; }

        public Directory Directory { get; set; }
    }
}
