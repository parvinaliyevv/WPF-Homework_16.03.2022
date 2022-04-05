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
    }
}
