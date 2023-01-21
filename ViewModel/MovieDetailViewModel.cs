using cinema_tickets_booking_app.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace cinema_tickets_booking_app.ViewModel
{
    public class MovieDetailViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }
        public MovieModel _MovieData = new MovieModel();
        public MovieModel MovieData
        {
            get
            {
                return _MovieData;
            }
            set
            {
                _MovieData = value;
                OnPropertyChanged(nameof(MovieData));
            }
        }
        public string _Title { get; set; }
        public string Title 
        {
            get 
            { 
                return _Title; 
            } 
            set 
            {
                _Title = value;
                OnPropertyChanged(nameof(Title));
            } 
        }
        public MovieDetailViewModel(MovieModel data)
        {
            PopulateData(data);
            TapCommand = new Command<MovieModel>(SelectMovie);
        }

        private void SelectMovie(MovieModel data)
        {
            
        }

        void PopulateData(MovieModel data)
        {
            MovieData = data;
            Title = data.Name;
        }
    }
}
