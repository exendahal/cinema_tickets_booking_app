using cinema_tickets_booking_app.Model;
using cinema_tickets_booking_app.ViewModel;

namespace cinema_tickets_booking_app.Views;
public partial class BookingPage : ContentPage
{
	public BookingPage(MovieModel movieData, SessionModel sessionData)
	{
		InitializeComponent();
        BindingContext = new BookingPageViewModel(movieData, sessionData);
    }
    private async void ButtonClickedBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void ButtonClickedZoom(object sender, EventArgs e)
    {

    }
}