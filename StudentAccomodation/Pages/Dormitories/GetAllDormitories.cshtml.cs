using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IDormitoryService;

namespace StudentAccomodation.Pages.Dormitories
{
    public class GetAllDormitoriesModel : PageModel
    {
        private IDormitoryService _dormService;
        public IEnumerable<Dormitoty> AllDormies { get; set; }

        public GetAllDormitoriesModel(IDormitoryService dormService)
        {
            _dormService = dormService;
        }

        public void OnGet()
        {
            AllDormies = _dormService.DisplayAllDormitories();
        }
        
    }
}
