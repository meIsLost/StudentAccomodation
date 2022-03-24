using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IRoomService;

namespace StudentAccomodation.Pages.Rooms
{
    public class DisplayAllRoomsModel : PageModel
    {
        private IRoomService _roomService;
        public IEnumerable<Room> AllRooms { get; set; }

        public DisplayAllRoomsModel(IRoomService Service)
        {
            _roomService = Service;
        }

        public void OnGet()
        {
            AllRooms = _roomService.DisplayAllRooms();
        }
        
    }
}
