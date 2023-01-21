using Reservation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class ReservationBook
    {
        private readonly List<Reserva> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reserva>();
        }

        public IEnumerable<Reserva> GetReservationsForUser(string username)
        {
            return _reservations.Where(r => r.UserName == username);
        }

        public void AddReservation(Reserva reservation)
        {
            foreach(Reserva existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }
    }
}
