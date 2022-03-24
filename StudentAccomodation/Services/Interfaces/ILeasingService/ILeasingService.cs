using StudentAccomodation.Models;

namespace StudentAccomodation.Services.Interfaces.ILeasingService
{
    public interface ILeasingService
    {
        public IEnumerable<Leasing> DisplayAllLeasings();
    }
}
