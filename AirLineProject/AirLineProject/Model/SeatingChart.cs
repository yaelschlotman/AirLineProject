using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class SeatingChart
    {


        public List<Seat> SeatList = new List<Seat>();
        public List<string> SeatLetters = new List<string>();


        public void AddLettersToSeatList()
        {
            SeatLetters.Add("A");
            SeatLetters.Add("B");
            SeatLetters.Add("C");
            SeatLetters.Add("D");
            SeatLetters.Add("E");
            SeatLetters.Add("F");
        }        


        public SeatingChart(int numberofrows, int rowwidth)
        {

            AddLettersToSeatList();

            for (int i = 1; i <= numberofrows; i++)
            {
                for (int x = 0; x < rowwidth; x++)
                {
                    SeatList.Add(new Seat(i, SeatLetters[x]));
                }
            }
        }
    }
}
