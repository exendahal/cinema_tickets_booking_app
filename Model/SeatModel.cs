
using cinema_tickets_booking_app.ViewModel;
using Microsoft.Maui.Graphics.Text;

namespace cinema_tickets_booking_app.Model
{
    public class SeatModel
    {       
        public int ColumnCount { get; set; }
        public List<SeatDetail> SeatDetail { get; set; }
        public List<string> SeatIndex { get { return GetCharList(SeatDetail); } }
        public int RowCount { get { return (int) (SeatDetail.Count / ColumnCount); } }
        List<string> GetCharList(List<SeatDetail> list)
        {
            char aChar = 'A';
            int aIndex = 1;
            List<string> charList = new List<string>();
            charList.Add(aChar.ToString());
            for (int i=1; i <= list.Count; i++)
            {
                if (aIndex == ColumnCount)
                {
                    aChar++;
                    charList.Add(aChar.ToString());
                    if(aChar == 'Z')
                    {
                        aChar = 'A';
                        aChar--;
                    }                       
                    aIndex = 1;
                }
                aIndex++;
            }
            return charList;
        }
    }

    public class SeatDetail : BaseViewModel
    {       
        public int Id { get; set; }
        public string SeatName { get; set; }

        public bool IsBooked { get; set; } = false;
        private bool _IsSelected { get; set; } = false;

        public bool IsSelected
        {
            get
            {
                return _IsSelected;
            }
            set
            {
                if (_IsSelected != value)
                {
                    _IsSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                    OnPropertyChanged(nameof(SelectColor));
                }

            }
        }

        public bool Visibility { get; set; } = true;
        public Color SelectColor { get { return IsSelected ? Color.FromArgb("#FF8036") : Color.FromArgb("#253554"); } }
    }


}
