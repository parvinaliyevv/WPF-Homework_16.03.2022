using System.Windows;
using System.Windows.Controls;

namespace EyeMedia.Views
{
    public partial class BrowsePage : Page
    {
        public BrowsePage()
        {
            InitializeComponent();

            DataContext = new ViewModels.BrowseViewModel();
        }

        private void CloseApp_MenuItemClicked(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
    }
}
