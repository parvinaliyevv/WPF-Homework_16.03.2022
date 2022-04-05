using System.Windows;
using System.Collections.ObjectModel;
using EyeMedia.Commands;
using EyeMedia.Services;
using EyeMedia.Models;

namespace EyeMedia.ViewModels
{
    public class BrowseViewModel: DependencyObject
    {
        #region Properties
        public ObservableCollection<ImageItem> ImageItems { get; set; }

        public ObservableCollection<VideoItem> VideoItems { get; set; }


        public int ItemsHeight
        {
            get { return (int)GetValue(ItemsHeightProperty); }
            set { SetValue(ItemsHeightProperty, value); }
        }
        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.Register("ItemsHeight", typeof(int), typeof(BrowseViewModel));

        public int ItemsWidth
        {
            get { return (int)GetValue(ItemsWidthProperty); }
            set { SetValue(ItemsWidthProperty, value); }
        }
        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.Register("ItemsWidth", typeof(int), typeof(BrowseViewModel));
        #endregion

        #region Commands
        public RelayCommand OpenImageItemCommand { get; set; }
        public RelayCommand OpenVideoItemCommand { get; set; }
        #endregion

        public BrowseViewModel()
        {
            ImageItems = new();
            VideoItems = new();

            ItemsHeight = 150;
            ItemsWidth = 150;

            OpenImageItemCommand = new RelayCommand(sender => MessageBox.Show("Image open!"));
            OpenVideoItemCommand = new RelayCommand(sender => MessageBox.Show("Video open!"));

            ImageItems.Add(new ImageItem(ImageService.GetImageFromPath(@"C:\Users\HP\Desktop\Data\hesen.jpeg")));
            ImageItems.Add(new ImageItem(ImageService.GetImageFromPath(@"C:\Users\HP\Desktop\Data\cropped-1440-900-991929.jpg")));
        }
    }
}
