using Reservation.Exceptions;
using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("SengltonSean Suits");

            try
            {
                hotel.MakeReservation(new Reserva(
                    new RoomID(1, 3),
                    "SengltonSean",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2)));

                hotel.MakeReservation(new Reserva(
                    new RoomID(1, 2),
                    "SengltonSean",
                    new DateTime(2000, 1, 3),
                    new DateTime(2000, 1, 4)));
            }
            catch(ReservationConflictException ex)
            {

            }
            
           IEnumerable<Reserva> reservations = hotel.GetAllReservations();
        }
    }
}
