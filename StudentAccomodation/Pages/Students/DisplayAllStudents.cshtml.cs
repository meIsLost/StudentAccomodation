using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IStudent;

namespace StudentAccomodation.Pages.Students
{
    public class DisplayAllStudentsModel : PageModel
    {
        private IStudentService _studentService;
        public IEnumerable<Student> AllStudents { get; set; }

        public DisplayAllStudentsModel(IStudentService Service)
        {
            _studentService = Service;
        }

        public void OnGet()
        {
            AllStudents = _studentService.DisplayAllStudents();
        }
    }
}
