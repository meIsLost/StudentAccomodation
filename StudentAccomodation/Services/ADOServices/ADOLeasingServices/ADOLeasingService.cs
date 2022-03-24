using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.ILeasingService;

namespace StudentAccomodation.Services.ADOServices.ADOLeasingServices
{
    public class ADOLeasingService : ILeasingService
    {
        private ADOLeasing _service;

        public ADOLeasingService(ADOLeasing service)
        {
            _service = service;
        }

       
        public IEnumerable<Leasing> DisplayAllLeasings()
        {
            return _service.DisplayAllLeasings();
        }
    }
}
