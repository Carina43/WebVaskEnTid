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

        [BindProperty]
        public string PhoneNumber { get; set; }

        public CancelBookingModel(BookingService bookingService)
        {
            _bookingService = bookingService;
            //Bookings = bookingService.GetAllBookings();
        }
        public void OnGet()
        {
        }

        public void OnPostRead()
        {
            foreach (var booking in _bookingService.GetAllBookings())
            {
                if (booking.PhoneNumber == PhoneNumber)
                {
                    Bookings.Add(booking);
                }
            }
            
        }

       
        public void OnPostDelete()
        {
           
        }
    }
}
