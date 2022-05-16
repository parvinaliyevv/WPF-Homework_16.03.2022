using System.Windows.Media;
using EyeMedia.Models.Abstract;

namespace EyeMedia.Models.Concrete
{
    public class VideoItem : ItemBase
    {
        public string VideoPath { get; set; }

        public VideoItem(ImageSource source, string videoPath) : base(source)
        {
            VideoPath = videoPath;
        }
    }
}
