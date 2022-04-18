using System.Windows.Media;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EyeMedia.Models.Abstract
{
    public class ItemBase: INotifyPropertyChanged
    {
        public ImageSource Image { get; set; }


        public ItemBase(ImageSource source) => Image = source;


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;
            if (handler is not null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
