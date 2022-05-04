using System.Windows;
using System.Collections.ObjectModel;
using EyeMedia.Commands;
using EyeMedia.DB;
using EyeMedia.Models.Abstract;
using Microsoft.Win32;

namespace EyeMedia.ViewModels
{
    public class BrowseViewModel : DependencyObject
    {
        #region Properties

        public ObservableCollection<ItemBase> Items { get; set; }


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

        public RelayCommand DisplayImagesCommand { get; set; }
        public RelayCommand DisplayVideosCommand { get; set; }

        public RelayCommand AddFileCommand { get; set; }
        public RelayCommand AddFolderCommand { get; set; }

        #endregion


        public BrowseViewModel()
        {
            Items = new();

            ItemsHeight = 150;
            ItemsWidth = 150;

            OpenImageItemCommand = new(sender => MainViewModel.GetInstance().SelectedPage = new Views.ImagePage());
            OpenVideoItemCommand = new(sender => MainViewModel.GetInstance().SelectedPage = new Views.VideoPage());

            DisplayImagesCommand = new(sender => { Items.Clear(); Database.GetInstance().ImageItems.ForEach(obj => Items.Add(obj)); });
            DisplayVideosCommand = new(sender => { Items.Clear(); Database.GetInstance().VideoItems.ForEach(obj => Items.Add(obj)); });

            AddFileCommand = new(sender => AddFile() );
            AddFolderCommand = new(sender => AddFolder() );
            
            Database.GetInstance().ImageItems.ForEach(obj => Items.Add(obj));
        }


        public void AddFile()
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;

            fileDialog.ShowDialog();

            foreach (var item in fileDialog.FileNames)
                Database.GetInstance().ImageItems.Add(Services.ImageService.GetImageFromPath(item));
        }

        public void AddFolder()
        {
            // var fileDialog = new FolderBrowserDialog();
            // 
            // 
            // fileDialog.ShowDialog();
           
        }
    }
}
