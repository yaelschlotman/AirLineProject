using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class Seat
    {
        string SeatLetter;
        int RowNumber;
        string SeatID;

        public Seat(int rownumber, string seatletter)
        {
            this.RowNumber = rownumber;
            this.SeatLetter = seatletter;
            this.SeatID = (RowNumber.ToString() + seatletter);
        }

        public override string ToString()
        {
            return SeatID;
        }
        public string _seatid
        {
            get
            {
                return SeatID;
            }
        }
    }
}
