using VaskEnTidLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VaskEnTid_Library.Repo;

namespace WebVaskEnTid.Pages
{
    public class BookingOverviewModel : PageModel
    {

        private readonly BookingRepo _bookingRepo;

        [BindProperty]
        public List<Booking> Bookings { get; set; }

        public BookingOverviewModel(BookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
            Bookings = bookingRepo.GetAll();
        }

        public void OnGet()
        {
        }
    }
}
