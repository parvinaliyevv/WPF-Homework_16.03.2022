using System.Windows.Media;

namespace EyeMedia.ViewModels
{
    public class ImageViewModel
    {
        public ImageSource Image { get; set; } = Services.ImageService.GetImageFromPath(@"C:\Users\HP\Desktop\Data\hesen.jpeg");
    }
}
