using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VaskEnTid_Library.Service;
using VaskEnTidLibrary.Model;
using System.Diagnostics;

namespace WebVaskEnTid.Pages
{
    public class CreateBookingModel : PageModel
    {
        private BookingService _bookingService = new BookingService();


        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        public DateOnly BookingDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        [BindProperty]
        public TimeOnly BookingTime { get; set; }
        [BindProperty]
        public int MachineID { get; set; }
        

        public CreateBookingModel(BookingService bookingService)
        {
            _bookingService = bookingService;
            //NewBooking = new Booking(1, 1, "test", DateOnly.FromDateTime(DateTime.Now), new TimeOnly(6,0,0));
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            Debug.WriteLine($"CreateBooking OnPost();   PhoneNumber: {PhoneNumber}");
            if (BookingTime.Hour >= 6 || BookingTime.Hour <= 21)
            {
                _bookingService.CreateBooking(MachineID, PhoneNumber, BookingDate, BookingTime);
            }
            else { Debug.WriteLine($"BookingTime out of bounds: {BookingTime}"); }

            return RedirectToPage("/Index");
        }

    }
}
