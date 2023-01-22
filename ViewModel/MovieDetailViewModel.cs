using cinema_tickets_booking_app.Model;
using cinema_tickets_booking_app.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace cinema_tickets_booking_app.ViewModel
{
    public class MovieDetailViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }
        public ObservableCollection<SessionModel> _SessionListData = new ObservableCollection<SessionModel>();
        public ObservableCollection<SessionModel> SessionListData
        {
            get
            {
                return _SessionListData;
            }
            set
            {
                _SessionListData = value;
                OnPropertyChanged(nameof(SessionListData));
            }
        }

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
            TapCommand = new Command<SessionModel>(SelectSession);
        }

        private async void SelectSession(SessionModel sessionData)
        {
            await App.Current.MainPage.Navigation.PushAsync((new BookingPage(MovieData, sessionData)));
        }

        void PopulateData(MovieModel data)
        {
            MovieData = data;
            Title = data.Name;
            SessionListData.Add(new SessionModel() {SessionTime = "14:00", SessionType="Pyc", SessionPlace= "Eurasia Cinema7", PriceAdult = 2200, PriceChild = 1000, PriceStudent = 1500 });
            SessionListData.Add(new SessionModel() {SessionTime = "15:10", SessionType="IMAX Pyc", SessionPlace= "Kinopark 8 IMAX Saryaka", PriceAdult = 3500, PriceChild = 1500, PriceStudent = 2500, PriceVip= 4000 });
            SessionListData.Add(new SessionModel() {SessionTime = "15:40", SessionType="Laser Eng", SessionPlace= "Kinopark 6 Keruencity Astana", PriceAdult = 2700, PriceChild = 900, PriceStudent = 1700 });
            SessionListData.Add(new SessionModel() {SessionTime = "14:00", SessionType="Sundara", SessionPlace= "Eurasia Cinema7", PriceAdult = 2200, PriceChild = 1000, PriceStudent = 1500 });
            SessionListData.Add(new SessionModel() {SessionTime = "16:00", SessionType="Pulchowk", SessionPlace= "Eurasia Cinema7", PriceAdult = 220, PriceChild = 1000, PriceStudent = 1500 });
            SessionListData.Add(new SessionModel() {SessionTime = "18:00", SessionType="Bhaktapur", SessionPlace= "Eurasia Cinema7", PriceAdult = 2200, PriceChild = 1000, PriceStudent = 1500 });
            SessionListData.Add(new SessionModel() {SessionTime = "20:00", SessionType="Pyc", SessionPlace= "Eurasia Cinema7", PriceAdult = 2200, PriceChild = 1000, PriceStudent = 1500 });
        }
    }
}
