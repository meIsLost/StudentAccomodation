using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IRoomService;

namespace StudentAccomodation.Services.ADOServices.ADORoomServices
{
    public class ADORoomServices : IRoomService
    {
        private ADORoom _service;

        public ADORoomServices(ADORoom service)
        {
            _service = service;
        }
        public IEnumerable<Room> DisplayAllRooms()
        {
            return _service.DisplayAllRoooms();
        }

        public IEnumerable<Room> DisplayVacantRooms(int id , string type)
        {
            return _service.DisplayVacantRooms( id ,  type);
        }

      
    }
}
