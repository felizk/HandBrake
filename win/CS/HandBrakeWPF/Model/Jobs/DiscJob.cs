using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandBrakeWPF.Model.Jobs
{
    public class DiscJob
    {
        public string Disc { get; set; }

        public List<DiscJobEncode> Encodes { get; set; }

        public DiscJobEncodePreset Preset { get; set; }
    }

    public class DiscJobEncodePreset
    {
        public int? Title { get; set; }

        public List<int> Audio { get; set; }

        public List<int> Subtitles { get; set; }

        public int? Width { get; set; }

        public bool Interlaced { get; set; }

        public bool Telecined { get; set; }

        public int? Quality { get; set; }

        public int? DefaultSubtitle { get; set; }

        public bool Anime { get; set; }

        public bool UseDecomb { get; set; }
    }

    public class DiscJobEncode 
    {
        public int? Title { get; set; }

        public int? ChapterStart { get; set; }

        public int? ChapterEnd { get; set; }

        public List<int> Audio { get; set; }

        public List<int> Subtitles { get; set; }

        public string FileName { get; set; }

        public int? Width { get; set; }

        public bool Interlaced { get; set; }

        public bool Telecined { get; set; }

        public int? Quality { get; set; }

        public int? DefaultSubtitle { get; set; }

        public bool UseDecomb { get; set; }
    }
}
