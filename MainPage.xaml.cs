using cinema_tickets_booking_app.ViewModel;

namespace cinema_tickets_booking_app;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

	
}

