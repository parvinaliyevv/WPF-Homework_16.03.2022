using EyeMedia.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace EyeMedia.Views
{
    public partial class ImagePage : Page
    {
        public ImagePage()
        {
            InitializeComponent();

            DataContext = new ImageViewModel();
        }


        private void ReturnMenu_ButtonClicked(object sender, RoutedEventArgs e)
            => MainViewModel.GetInstance().SelectedPage = new BrowsePage();
    }
}
