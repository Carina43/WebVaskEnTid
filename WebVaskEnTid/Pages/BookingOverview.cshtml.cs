using VaskEnTidLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VaskEnTid_Library.Service;

namespace WebVaskEnTid.Pages
{
    public class BookingOverviewModel : PageModel
    {

        private readonly BookingService _bookingService;

        [BindProperty]
        public List<Booking> Bookings { get; set; }

        public BookingOverviewModel(BookingService bookingService)
        {
            _bookingService = bookingService;
            Bookings = bookingService.GetAllBookings();
        }

        public void OnGet()
        {
        }
    }
}
