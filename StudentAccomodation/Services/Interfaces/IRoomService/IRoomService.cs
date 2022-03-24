using StudentAccomodation.Models;

namespace StudentAccomodation.Services.Interfaces.IRoomService
{
    public interface IRoomService
    {
        public IEnumerable<Room> DisplayAllRooms();

        public IEnumerable<Room> DisplayVacantRooms(int id, string type);
    }
}
