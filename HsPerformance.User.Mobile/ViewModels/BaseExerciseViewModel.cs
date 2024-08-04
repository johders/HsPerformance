namespace HsPerformance.User.Mobile.ViewModels
{
    public class BaseExerciseViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl 
        { 
            get 
            {
                if(VideoUrl != null)
                {
                    string imgLink = "https://img.youtube.com/vi/";
                    string[] temp = VideoUrl.Split(new char[] { '=', '&' });
                    return $"{imgLink}{temp[1]}/2.jpg";
                }
                return "https://answers-afd.microsoft.com/static/images/image-not-found.jpg";
            }
        }
        public string Description { get; set; }

    }
}
