using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class Reservation
    {
        public RoomID RoomId { get; }
        public string UserName { get; set; }
        public DateTime StarTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime.Subtract(StarTime);

        public Reservation(RoomID roomId, string username, DateTime starTime, DateTime endTime)
        {
            RoomId = roomId;
            UserName = username;
            StarTime = starTime;
            EndTime = endTime;

        }
    }
}
