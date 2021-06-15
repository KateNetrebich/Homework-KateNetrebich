namespace EFPractice.Core.Entities
{
    public class Directory : Entity
    {
        public int ParentDirectoryId { get; set; }
        public string Title { get; set; }
    }
}
