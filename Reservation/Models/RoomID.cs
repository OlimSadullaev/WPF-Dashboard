
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Converters;

namespace Reservation.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }

        public int RoomNumber { get; }

        public override bool Equals(object obj)
        {
            return obj is RoomID roomID && 
                roomID.FloorNumber == FloorNumber && 
                roomID.RoomNumber == RoomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }
    }
}
