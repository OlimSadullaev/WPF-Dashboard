using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private Reserva _reservation;

        public string RoomID => _reservation.RoomID?.ToString();
        public string UserName => _reservation.UserName;
        public DateTime StarDate => _reservation.StarTime;
        public DateTime EndDate => _reservation.EndTime;

        public ReservationViewModel(Reserva reservation)
        {
            _reservation = reservation;
        }

    }
}
