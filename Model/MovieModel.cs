namespace cinema_tickets_booking_app.Model
{
    public class MovieModel
    {
        public double Rating { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public Color RatingColor { get { return Rating >= 7 ? Color.FromArgb("#FF8036") : Color.FromArgb("#1A2232"); } }
    }
}
