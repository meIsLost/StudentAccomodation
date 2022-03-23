using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IApartmentService;

namespace StudentAccomodation.Pages._Apartment
{
    public class DisplayApartmentsModel : PageModel
    {
       private IApartmentService _apartmentService;
        public IEnumerable<Apartment> AllApartments { get; set; }

        public DisplayApartmentsModel(IApartmentService apartmentService )
        {
            _apartmentService = apartmentService;
        }

        public void OnGet()
        {
            AllApartments=_apartmentService.DisplayAllapartments();
        }
    }
}
