using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IStudent;

namespace StudentAccomodation.Services.ADOServices.ADOStudentServices
{
    public class ADOStudentService : IStudentService
    {
        private ADOStudent _service;

        public ADOStudentService(ADOStudent service)
        {
            _service = service;
        }
        public IEnumerable<Student> DisplayAllStudents()
        {
            return _service.DisplayAllStudents();
        }
    }
}
 