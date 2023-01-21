using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reserva ExistingRservation { get; }
        public Reserva IncomingRservation { get; }

        public ReservationConflictException(Reserva existingRservation, Reserva incomingRservation)
        {
            ExistingRservation = existingRservation;
            IncomingRservation = incomingRservation;
        }

        public ReservationConflictException(string message, Reserva existingRservation, Reserva incomingRservation) : base(message)
        {
            ExistingRservation = existingRservation;
            IncomingRservation = incomingRservation;
        }

        public ReservationConflictException(string? message, Exception? innerException, Reserva existingRservation, Reserva incomingRservation) : base(message, innerException)
        {
            ExistingRservation = existingRservation;
            IncomingRservation = incomingRservation;
        }
    }
}
