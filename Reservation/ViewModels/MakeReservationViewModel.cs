using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Reservation.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _username;

        public string UserName
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                OnProPertyChange(nameof(UserName));
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

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel()
        {

        }
    }
}
