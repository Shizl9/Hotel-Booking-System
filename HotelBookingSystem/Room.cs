using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    internal class Room
    {
        public int Id { get; set; }
        public string ?RoomNumber { get; set; }
        public string ?Type { get; set; }
        public double PricePerNight { get; set; }
        public bool IsBooked { get; set; }
        public int Floor { get; set; }
    }
}
