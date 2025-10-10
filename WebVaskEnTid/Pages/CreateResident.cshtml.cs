using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VaskEnTid_Library.Service;

namespace WebVaskEnTid.Pages
{
    public class CreateResidentModel : PageModel
    {

        private BookingService _bookingService = new BookingService();

       
        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Adress { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string ApartmentNo { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public CreateResidentModel(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine($"CreateResident OnPost();   PhoneNumber: {PhoneNumber}");
            _bookingService.CreateResident(PhoneNumber, FirstName, LastName, Adress, ZipCode, City, ApartmentNo, Email);
            return RedirectToPage("/Index");
        }
    }
}
