namespace cinema_tickets_booking_app.Model
{
    public class MovieModel
    {
        public double ImdbRating { get; set; }
        public double KinopoiskRating { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Certificate { get; set; }
        public string Runtime { get; set; }
        public string Release { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public Color RatingColor { get { return ImdbRating >= 7 ? Color.FromArgb("#FF8036") : Color.FromArgb("#1A2232"); } }
    }
}
