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

        public Seat(int rownumber, string seatletter)
        {
            this.RowNumber = rownumber;
            this.SeatLetter = seatletter;
        }

        public override string ToString()
        {
            return (RowNumber.ToString() + SeatLetter);
        }
    }
}
