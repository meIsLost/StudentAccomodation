using StudentAccomodation.Models;

namespace StudentAccomodation.Services.Interfaces.IDormitoryService
{
    public interface  IDormitoryService
    {
        public IEnumerable<Dormitoty> DisplayAllDormitories();
    }
}
