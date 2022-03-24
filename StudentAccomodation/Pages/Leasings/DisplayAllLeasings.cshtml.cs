using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.ILeasingService;

namespace StudentAccomodation.Pages.Leasings
{
    public class DisplayAllLeasingsModel : PageModel
    {
        private ILeasingService _leasingService;
        public IEnumerable<Leasing> AllLeases { get; set; }

        public DisplayAllLeasingsModel(ILeasingService Service)
        {
            _leasingService = Service;
        }

        public void OnGet()
        {
            AllLeases = _leasingService.DisplayAllLeasings();
        }
        
    }
}
