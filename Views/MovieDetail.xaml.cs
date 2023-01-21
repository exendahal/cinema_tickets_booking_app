using cinema_tickets_booking_app.Model;
using cinema_tickets_booking_app.ViewModel;

namespace cinema_tickets_booking_app.Views;

public partial class MovieDetail : ContentPage
{
	public MovieDetail(MovieModel data)
	{
		InitializeComponent();
        BindingContext = new MovieDetailViewModel(data);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}