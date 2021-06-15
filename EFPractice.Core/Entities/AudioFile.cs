namespace EFPractice.Core.Entities
{
    public class AudioFile : File
    {
        public int Bitrate { get; set; }
        public int SampleRate { get; set; }
        public int ChannelCount { get; set; }
        public string Duration { get; set; }
    }
}
