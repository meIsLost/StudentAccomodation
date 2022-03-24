using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IDormitoryService;

namespace StudentAccomodation.Services.ADOServices.ADODormitoryServices
{
    public class ADODormitoryServices : IDormitoryService
    {
        private ADODormitory _service;

        public ADODormitoryServices(ADODormitory service)
        {
            _service = service;
        }

        public IEnumerable<Dormitoty> DisplayAllDormitories()
        {
            return _service.DisplayAllDormitories();
        }
    }
}
