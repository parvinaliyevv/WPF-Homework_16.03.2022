using System.Windows;
using System.Windows.Controls;
using EyeMedia.Views;

namespace EyeMedia.ViewModels
{
    public class MainViewModel: DependencyObject
    {
        public Page SelectedPage
        {
            get { return (Page)GetValue(SelectedPageProperty); }
            set { SetValue(SelectedPageProperty, value); }
        }
        public static readonly DependencyProperty SelectedPageProperty =
            DependencyProperty.Register("SelectedPage", typeof(Page), typeof(MainViewModel));


        public MainViewModel()
        {
            SelectedPage = new VideoPage();
        }
    }
}
