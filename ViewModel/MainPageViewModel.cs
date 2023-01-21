using cinema_tickets_booking_app.Model;
using cinema_tickets_booking_app.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace cinema_tickets_booking_app.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }
        public ObservableCollection<MovieModel> _MovieListData = new ObservableCollection<MovieModel>();
        public ObservableCollection<MovieModel> MovieListData
        {
            get
            {
                return _MovieListData;
            }
            set
            {
                _MovieListData = value;
                OnPropertyChanged(nameof(MovieListData));
            }
        }

        public MainPageViewModel()
        {
            PopulateData();
            TapCommand = new Command<MovieModel>(SelectMovie);
        }

        private async void SelectMovie(MovieModel data)
        {            
            await App.Current.MainPage.Navigation.PushAsync((new MovieDetail(data)));
        }

        void PopulateData()
        {
            MovieListData.Clear();
            MovieListData.Add(new MovieModel() { ImdbRating = 8.1, KinopoiskRating = 7.9, Name = "The Batman", Category = "Action", ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRBkxgl2A2PhE_6tklFLT0bxn5NLhvhsnpXGhmXBt_zotrlVHmo", Description = "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.", Certificate ="16+",Runtime = "02:56", Release = "2022", Director = "Matt Reeves", Cast = "Robert Pattinson, Zoë Kravitz, Jeffrey Wright, Colin Farrell, Paul Dano, John Turturro, \tAndy Serkis, Peter Sarsgaard" });
            MovieListData.Add(new MovieModel() { ImdbRating = 7.9, KinopoiskRating = 7.9, Name = "Unchartared", Category = "Adventure", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCAT4deET55wX0MzpBp45_7201ZndSAI8m2W52rNVeVmEbEgEW", Description = "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.", Certificate = "16+", Runtime = "02:56", Release = "2022", Director = "Matt Reeves", Cast = "Robert Pattinson, Zoë Kravitz, Jeffrey Wright, Colin Farrell, Paul Dano, John Turturro, \tAndy Serkis, Peter Sarsgaard" });
            MovieListData.Add(new MovieModel() { ImdbRating = 5.6, KinopoiskRating = 7.9, Name = "The Exorcism of God", Category = "Horror/Drama ", ImageUrl = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRWQHOXXw3Q-84Ikx4He5dbklnWM7vBZMhdItn0TrLOvOHbFtji", Description= "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.", Certificate = "16+", Runtime = "02:56", Release = "2022", Director = "Matt Reeves", Cast = "Robert Pattinson, Zoë Kravitz, Jeffrey Wright, Colin Farrell, Paul Dano, John Turturro, \tAndy Serkis, Peter Sarsgaard" });
            MovieListData.Add(new MovieModel() { ImdbRating = 7.1, KinopoiskRating = 7.9, Name = "Turning Red", Category = "Family/Comedy", ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRUC5oNSCikec3GcxjXnpxCTRAo-ZoUVGiIVcbFLA8p6SN2lxVi", Description = "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.", Certificate = "16+", Runtime = "02:56", Release = "2022", Director = "Matt Reeves", Cast = "Robert Pattinson, Zoë Kravitz, Jeffrey Wright, Colin Farrell, Paul Dano, John Turturro, \tAndy Serkis, Peter Sarsgaard" });
            MovieListData.Add(new MovieModel() { ImdbRating = 8.1, KinopoiskRating = 7.9, Name = "Spider-Man: No Way Home", Category = "Action/Sci-fi", ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQtU4DiRFRr0155DjcHlSsgJy9opzt_MPMJmHfG4MEa31-A82Xb", Description = "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.", Certificate = "16+", Runtime = "02:56", Release = "2022", Director = "Matt Reeves", Cast = "Robert Pattinson, Zoë Kravitz, Jeffrey Wright, Colin Farrell, Paul Dano, John Turturro, \tAndy Serkis, Peter Sarsgaard" });
            MovieListData.Add(new MovieModel() { ImdbRating = 5.3, KinopoiskRating = 7.9, Name = "Morbius", Category = "Action/Sci-fi", ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSlqKqkW0oljnsL6r__e2RL1bJbPc6J_BYu2S8jbqTmvfVY4rtZ" , Description = "When the Riddler, a sadistic serial killer, begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement.", Certificate = "16+", Runtime = "02:56", Release = "2022", Director = "Matt Reeves", Cast = "Robert Pattinson, Zoë Kravitz, Jeffrey Wright, Colin Farrell, Paul Dano, John Turturro, \tAndy Serkis, Peter Sarsgaard" });
        }
    }
}
