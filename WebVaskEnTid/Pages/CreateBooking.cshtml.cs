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
        //private int[] _allowedHours = new int[2] { 6, 21 }

        [BindProperty]
        public Booking NewBooking { get; set; }

        public CreateBookingModel(BookingService bookingService)
        {
            _bookingService = bookingService;
            NewBooking = new Booking(1, 1, "test", DateOnly.FromDateTime(DateTime.Now), new TimeOnly(6,0,0));
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            Debug.WriteLine($"CreateBooking OnPost();   PhoneNumber: {NewBooking.PhoneNumber}");
            if (NewBooking.BookingTime.Hour >= 6 || NewBooking.BookingTime.Hour <= 21)
            {
                _bookingService.CreateBooking(NewBooking);
            }
            else { Debug.WriteLine($"BookingTime out of bounds: {NewBooking.BookingTime}"); }

            return RedirectToPage("/Index");
        }

    }
}
