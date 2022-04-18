using System.Windows;

namespace EyeMedia
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainView = new Views.MainView()
            {
                DataContext = ViewModels.MainViewModel.GetInstance()
            };

            mainView.ShowDialog();

            base.OnStartup(e);
        }
    }
}
