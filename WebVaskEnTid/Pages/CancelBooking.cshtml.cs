using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VaskEnTid_Library.Service;
using VaskEnTidLibrary.Model;

namespace WebVaskEnTid.Pages
{
    public class CancelBookingModel : PageModel
    {

        private readonly BookingService _bookingService;

        [BindProperty]
        public List<Booking> Bookings { get; set; }

        public CancelBookingModel(BookingService bookingService)
        {
            _bookingService = bookingService;
            Bookings = bookingService.CancelBooking();
        }
        public void OnGet()
        {
        }
    }
}
