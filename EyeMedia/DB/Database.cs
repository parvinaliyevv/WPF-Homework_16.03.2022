using EyeMedia.Models.Concrete;
using System.Collections.Generic;

namespace EyeMedia.DB
{
    public class Database
    {
        private static Database? _instance;


        public List<ImageItem> ImageItems { get; set; }
        public List<VideoItem> VideoItems { get; set; }


        private Database()
        {
            ImageItems = new()
            {
                //new ImageItem(Services.ImageService.GetImageFromPath(@"C:\Users\Aliy_ql08\Desktop\WPF-Homework_16.03.2022\EyeMedia\Video\sharp.png")),
            };

            VideoItems = new()
            {
                //new VideoItem(Services.ImageService.GetImageFromPath(@"C:\Users\Aliy_ql08\Desktop\WPF-Homework_16.03.2022\EyeMedia\Video\sharp.png")),
            };
        }


        public static Database GetInstance()
        {
            if (_instance is null) _instance = new();

            return _instance;
        }
    }
}
