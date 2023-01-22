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

    private async void ButtonClickedBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void ButtonClickedAbout(object sender, EventArgs e)
    {
        AboutBtn.TextColor = Color.FromArgb("#FF8036");
        AboutIndicator.Stroke = Color.FromArgb("#FF8036");
        AboutIndicator.BackgroundColor = Color.FromArgb("#FF8036");
        SessionsBtn.TextColor = Color.FromArgb("#637394");
        SessionsIndicator.Stroke = Color.FromArgb("#637394");
        SessionsIndicator.BackgroundColor = Color.FromArgb("#637394");
        AboutPage.IsVisible = true;
        SessionsPage.IsVisible = false;
    }

    private void ButtonClickedSession(object sender, EventArgs e)
    {
        SessionsBtn.TextColor = Color.FromArgb("#FF8036");
        SessionsIndicator.Stroke = Color.FromArgb("#FF8036");
        SessionsIndicator.BackgroundColor = Color.FromArgb("#FF8036");
        AboutBtn.TextColor = Color.FromArgb("#637394");
        AboutIndicator.Stroke = Color.FromArgb("#637394");
        AboutIndicator.BackgroundColor = Color.FromArgb("#637394");
        SessionsPage.IsVisible = true;
        AboutPage.IsVisible = false;
    }
}