using System.Windows.Controls;

namespace EyeMedia.Views
{
    public partial class ImagePage : Page
    {
        public ImagePage()
        {
            InitializeComponent();

            DataContext = new ViewModels.ImageViewModel();
        }
    }
}
