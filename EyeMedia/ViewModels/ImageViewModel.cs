using System.Windows.Media;

namespace EyeMedia.ViewModels
{
    public class ImageViewModel
    {
        public ImageSource Image { get; set; }


        public ImageViewModel(ImageSource ımage)
        {
            Image = ımage;
        }
    }
}
