using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using EyeMedia.Commands;
using EyeMedia.DB;
using EyeMedia.Models.Abstract;
using EyeMedia.Models.Concrete;
using Ookii.Dialogs.Wpf;

namespace EyeMedia.ViewModels
{
    public class BrowseViewModel : DependencyObject
    {
        #region Properties

        public ObservableCollection<ItemBase> Items { get; set; }

        public bool IsImageItems { get; set; }


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
            IsImageItems = true;

            ItemsHeight = 150;
            ItemsWidth = 150;

            OpenImageItemCommand = new(sender => MainViewModel.GetInstance().SelectedPage = new Views.ImagePage(((sender as Border).DataContext as ImageItem).Image));
            OpenVideoItemCommand = new(sender => MainViewModel.GetInstance().SelectedPage = new Views.VideoPage(((sender as Border).DataContext as VideoItem).VideoPath));

            DisplayImagesCommand = new(sender => { Items.Clear(); Database.GetInstance().ImageItems.ForEach(obj => Items.Add(obj)); IsImageItems = true; });
            DisplayVideosCommand = new(sender => { Items.Clear(); Database.GetInstance().VideoItems.ForEach(obj => Items.Add(obj)); IsImageItems = false; });

            AddFileCommand = new(sender => AddFile() );
            AddFolderCommand = new(sender => AddFolder() );
            
            Database.GetInstance().ImageItems.ForEach(obj => Items.Add(obj));
        }

        public void AddFile()
        {
            var fileDialog = new VistaOpenFileDialog();
            
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            if (IsImageItems)
                fileDialog.Filter = "PNG Files(*.png)|*.png|JPEG Files(*.jpeg)|*.jpeg|JPG Files(*.jpg)|*.jpg";
            else
                fileDialog.Filter = "MP4 Files(*.mp4)|*.mp4|AVI Files(*.avi)|*.avi|MOV Files(*.mov)|*.mov";

            fileDialog.FilterIndex = 1;

            if (fileDialog.ShowDialog() is false) return;

            if (IsImageItems)
            {
                foreach (var item in fileDialog.FileNames)
                {
                    var database = Database.GetInstance();
                    database.ImageItems.Add(new(Services.ImageService.GetImageFromPath(item)));
                }

                DisplayImagesCommand.Execute(null);
            }
            else
            {
                foreach (var item in fileDialog.FileNames)
                {
                    var database = Database.GetInstance();
                    database.VideoItems.Add(new(Services.ImageService.GetImageFromPath(@"C:\Users\Aliy_ql08\Desktop\WPF-Homework_16.03.2022\EyeMedia\multimedia.png"), item));
                }

                DisplayVideosCommand.Execute(null);
            }
        }

        public void AddFolder()
        {
            var fileDialog = new VistaFolderBrowserDialog();

            if (fileDialog.ShowDialog() is false) return;

            if (IsImageItems)
            {
                var files = Directory.GetFiles(fileDialog.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpeg") || s.EndsWith(".jpg"));

                foreach (var item in files)
                {
                    var database = Database.GetInstance();
                    database.ImageItems.Add(new(Services.ImageService.GetImageFromPath(item)));
                }

                DisplayImagesCommand.Execute(null);
            }
            else
            {
                var files = Directory.GetFiles(fileDialog.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".mp4") || s.EndsWith(".avi") || s.EndsWith(".mov"));

                foreach (var item in files)
                {
                    var database = Database.GetInstance();
                    database.VideoItems.Add(new(Services.ImageService.GetImageFromPath(@"C:\Users\Aliy_ql08\Desktop\WPF-Homework_16.03.2022\EyeMedia\multimedia.png"), item));
                }

                DisplayVideosCommand.Execute(null);
            }
        }
    }
}
