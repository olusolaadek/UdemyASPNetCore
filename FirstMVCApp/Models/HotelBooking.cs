namespace FirstMVCApp.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public DateTime DateStart { get; set; } //= DateTime.Now;
        public DateTime DateEnd { get; set; } // = DateTime.Now;
    }
}
