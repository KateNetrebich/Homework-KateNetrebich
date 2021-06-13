using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice.Core.Entities
{
    public class AudioFiles
    {
        public int Id { get; set; }
        public int Bitrate { get; set; }
        public int SampleRate { get; set; }
        public int ChannelCount { get; set; }
        public string Duration { get; set; }
    }
}
