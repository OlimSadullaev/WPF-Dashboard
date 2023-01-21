﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; set; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reserva> GetAllReservations()
        {
            return _reservationBook.GetAllReservations();
        }

        public void MakeReservation(Reserva reserva)
        {
            _reservationBook.AddReservation(reserva);
        }
    }
}
