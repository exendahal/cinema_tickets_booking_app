
namespace cinema_tickets_booking_app.Model
{
    public class SessionModel
    {
        public string SessionTime { get; set; }
        public string SessionType { get; set; }
        public string SessionPlace { get; set; }
        public double PriceAdult { get; set; }
        public string PriceAdultString { get { return PriceAdult <= 0 ? "." : PriceAdult.ToString(); } }
        public double PriceChild { get; set; }
        public string PriceChildString { get { return PriceChild <= 0 ? "." : PriceChild.ToString(); } }
        public double PriceStudent { get; set; }
        public string PriceStudentString { get { return PriceStudent <= 0 ? "." : PriceStudent.ToString(); } }
        public double PriceVip { get; set; }
        public string PriceVipString { get { return PriceVip <= 0 ? "." : PriceVip.ToString(); } }
    }
}
