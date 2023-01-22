using cinema_tickets_booking_app.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace cinema_tickets_booking_app.ViewModel
{
    public class BookingPageViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }
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

        public string _SessionPlace { get; set; }
        public string SessionPlace
        {
            get
            {
                return _SessionPlace;
            }
            set
            {
                _SessionPlace = value;
                OnPropertyChanged(nameof(SessionPlace));
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

        public SessionModel _SessionData = new SessionModel();
        public SessionModel SessionData
        {
            get
            {
                return _SessionData;
            }
            set
            {
                _SessionData = value;
                OnPropertyChanged(nameof(SessionData));
            }
        }

        public SeatModel _SeatData = new SeatModel();
        public SeatModel SeatData
        {
            get
            {
                return _SeatData;
            }
            set
            {
                _SeatData = value;
                OnPropertyChanged(nameof(SeatData));
            }
        }

        public ObservableCollection<SeatDetail> _SeatListData = new ObservableCollection<SeatDetail>();
        public ObservableCollection<SeatDetail> SeatListData
        {
            get
            {
                return _SeatListData;
            }
            set
            {
                _SeatListData = value;
                OnPropertyChanged(nameof(SeatListData));
            }
        }

        public int _ListWidth { get; set; }
        public int ListWidth
        {
            get
            {
                return _ListWidth;
            }
            set
            {
                _ListWidth = value;
                OnPropertyChanged(nameof(ListWidth));
            }
        }
        public BookingPageViewModel(MovieModel movieData, SessionModel sessionData)
        {
            TapCommand = new Command<SeatDetail>(SelectSeat);
            Title = movieData.Name;
            SessionPlace = sessionData.SessionPlace;
            MovieData = movieData;
            SessionData = sessionData;
            List<SeatDetail> _list = new List<SeatDetail>();
            for (int i = 1; i <= 72; i++)
                _list.Add(new SeatDetail() { Id = i, SeatName = i == 11 ? "x" : i.ToString(), Visibility = i >= 25 && i <= 30 ? false : true, IsBooked = i == 11 ? true : false }); ;
            SeatData.ColumnCount = 11;
            SeatData.SeatDetail = _list;
            ListWidth = 16 + (SeatData.RowCount * 68);
        }

        private void SelectSeat(SeatDetail obj)
        {
            if (!obj.IsSelected && !obj.IsBooked)
                obj.IsSelected = true;
            else
                obj.IsSelected = false;
        }
    }
}
