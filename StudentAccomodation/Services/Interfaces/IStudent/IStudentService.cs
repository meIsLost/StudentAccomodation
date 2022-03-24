using StudentAccomodation.Models;

namespace StudentAccomodation.Services.Interfaces.IStudent
{
    public interface IStudentService
    {
        public IEnumerable<Student> DisplayAllStudents();
    }
}
