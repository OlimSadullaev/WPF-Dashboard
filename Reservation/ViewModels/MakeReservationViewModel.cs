using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservation.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;

        public string Myproperty
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                OnProPertyChange(nameof(Myproperty));
            }
        }

        private int _floorNumber;

        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }

            set
            {
                _floorNumber = value;
                OnProPertyChange(nameof(FloorNumber));
            }
        }

        private int _roomNumber;

        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }

            set
            {
                _roomNumber = value;
                OnProPertyChange(nameof(RoomNumber));
            }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }

            set
            {
                _startDate = value;
                OnProPertyChange(nameof(StartDate));
            }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }

            set
            {
                _endDate = value;
                OnProPertyChange(nameof(EndDate));
            }
        }
    }
}
