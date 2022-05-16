using EyeMedia.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EyeMedia.Views
{
    public partial class ImagePage : Page
    {
        public ImagePage(ImageSource image)
        {
            InitializeComponent();

            DataContext = new ImageViewModel(image);
        }


        private void ReturnMenu_ButtonClicked(object sender, RoutedEventArgs e)
            => MainViewModel.GetInstance().SelectedPage = new BrowsePage();
    }
}
