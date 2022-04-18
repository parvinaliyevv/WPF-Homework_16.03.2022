using System.Windows;
using System.Collections.ObjectModel;
using EyeMedia.Commands;
using EyeMedia.Models.Abstract;
using EyeMedia.DB;
using System.Collections.Generic;
using System.Linq;

namespace EyeMedia.ViewModels
{
    public class BrowseViewModel: DependencyObject
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

        public RelayCommand DisplayImages { get; set; }
        public RelayCommand DisplayVideos { get; set; }

        #endregion


        public BrowseViewModel()
        {
            Items = new();

            ItemsHeight = 150;
            ItemsWidth = 150;
            
            OpenImageItemCommand = new(sender => MainViewModel.GetInstance().SelectedPage = new Views.ImagePage());
            OpenVideoItemCommand = new(sender => MainViewModel.GetInstance().SelectedPage = new Views.VideoPage());

                          DisplayImages = new(sender => { Items.Clear(); Database.GetInstance().ImageItems.ForEach(obj => Items.Add(obj)); });
            DisplayVideos = new(sender => { Items.Clear(); Database.GetInstance().VideoItems.ForEach(obj => Items.Add(obj)); });

            Database.GetInstance().ImageItems.ForEach(obj => Items.Add(obj));
        }
    }
}
