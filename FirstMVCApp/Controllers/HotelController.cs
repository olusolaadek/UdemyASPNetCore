using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            HotelBooking hotel = new HotelBooking()
            {
                Id = 1,
                DateStart = new DateTime(2022, 6, 22),
                DateEnd = new DateTime(2022, 6, 24),
                GuestName = "Olusola Adekunle"
            };

            return View(hotel);
        }

        public IActionResult HotelBookingDetails()
        {
            HotelBooking booking =
                new HotelBooking()
                {
                    Id = 1,
                    DateStart = new DateTime(2022, 6, 22),
                    DateEnd = new DateTime(2022, 6, 24),
                    GuestName = "Olusola Adekunle"
                };

            return View(booking);
        }
    }
}
