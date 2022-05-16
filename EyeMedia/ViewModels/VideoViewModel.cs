namespace EyeMedia.ViewModels
{
    public class VideoViewModel
    {
        public string Path { get; set; }


        public VideoViewModel(string path)
        {
            Path = path;
        }
    }
}
