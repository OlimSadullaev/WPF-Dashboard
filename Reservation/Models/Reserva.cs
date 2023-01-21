using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class Reserva
    {
        public RoomID RoomID { get; }
        public string UserName { get; set; }
        public DateTime StarTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime.Subtract(StarTime);

        public Reserva(RoomID roomId, string username, DateTime starTime, DateTime endTime)
        {
            RoomID = roomId;
            UserName = username;
            StarTime = starTime;
            EndTime = endTime;

        }

        public bool Conflicts(Reserva reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.StarTime < EndTime && reservation.EndTime > StarTime;
        }
    }
}
