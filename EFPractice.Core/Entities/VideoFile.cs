namespace EFPractice.Core.Entities
{
    public class VideoFile : File
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Duration { get; set; }
    }
}
