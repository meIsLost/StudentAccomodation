using StudentAccomodation.Models;

namespace StudentAccomodation.Services.Interfaces.IApartmentService
{
    public interface IApartmentService
    {

        public IEnumerable<Apartment> DisplayAllapartments();
    }
}
