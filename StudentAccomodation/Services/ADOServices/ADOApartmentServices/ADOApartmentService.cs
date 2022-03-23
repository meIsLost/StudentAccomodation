using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IApartmentService;

namespace StudentAccomodation.Services.ADOServices.ADOApartmentServices
{
    public class ADOApartmentService : IApartmentService
    {
        private ADOApartment _service;
        
        public ADOApartmentService(ADOApartment service)
        {
            _service = service;
        }

        public IEnumerable<Apartment> DisplayAllapartments()
        {
            throw new NotImplementedException();
        }
    }
}
