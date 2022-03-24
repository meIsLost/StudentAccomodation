using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAccomodation.Models;
using StudentAccomodation.Services.Interfaces.IRoomService;

namespace StudentAccomodation.Pages
{
    public class DisplayVacantRoomsModel : PageModel
    {
        private IRoomService _roomService;
        public IEnumerable<Room> AllRooms { get; set; }

        public DisplayVacantRoomsModel(IRoomService Service)
        {
            _roomService = Service;
        }

        public void OnGet(int id, string type)
        {
            AllRooms = _roomService.DisplayVacantRooms(id,  type);
        }
    }
}
