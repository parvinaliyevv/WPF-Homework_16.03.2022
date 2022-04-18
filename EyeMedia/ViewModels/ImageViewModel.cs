using System.Windows.Media;

namespace EyeMedia.ViewModels
{
    public class ImageViewModel
    {
        public ImageSource Image { get; set; } = Services.ImageService.GetImageFromPath(@"C:\Users\Aliy_ql08\Desktop\WPF-Homework_16.03.2022\EyeMedia\Video\sharp.png");
    }
}
