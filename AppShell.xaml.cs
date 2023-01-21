using cinema_tickets_booking_app.Views;

namespace cinema_tickets_booking_app;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("MovieDetail", typeof(MovieDetail));
    }
}
