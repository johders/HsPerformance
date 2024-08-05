using CommunityToolkit.Mvvm.ComponentModel;

namespace HsPerformance.User.Mobile.ViewModels
{
    public partial class BaseExerciseViewModel : ObservableObject
    {
        [ObservableProperty]
        private Guid _id;

        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _videoUrl = string.Empty;

        [ObservableProperty]
        private string _description = string.Empty;

        public string ImageUrl
        {
            get
            {
                if (VideoUrl != null)
                {
                    string imgLink = "https://img.youtube.com/vi/";
                    string[] temp = VideoUrl.Split(new char[] { '=', '&' });
                    return $"{imgLink}{temp[1]}/2.jpg";
                }
                return "https://answers-afd.microsoft.com/static/images/image-not-found.jpg";
            }
        }

    }
}
