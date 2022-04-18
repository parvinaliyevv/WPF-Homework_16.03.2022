using System.Windows.Media;
using EyeMedia.Models.Abstract;

namespace EyeMedia.Models.Concrete
{
    public class ImageItem : ItemBase
    {
        public ImageItem(ImageSource source) : base(source) { }
    }
}
