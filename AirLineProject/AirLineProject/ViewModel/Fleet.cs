using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model
{
    public class Fleet
    {
        public Aircraft GenerateAirlplane(string aircraftID, int capacity, int range, bool IsAircraftUndergoingMaintinance)
        {
            return (new Aircraft(aircraftID, capacity, range, IsAircraftUndergoingMaintinance));
        }
        public List<Aircraft> BuildInitalFleet()
        {
            List < Aircraft > fleet = new List<Aircraft>(); 
            fleet.Add(GenerateAirlplane("A01", 54, 4000, true));
            fleet.Add(GenerateAirlplane("A02", 54, 4000, false));
            fleet.Add(GenerateAirlplane("A03", 54, 3500, false));
            fleet.Add(GenerateAirlplane("A04", 54, 3500, false));
            fleet.Add(GenerateAirlplane("A05", 54, 3500, false));
            fleet.Add(GenerateAirlplane("A06", 54, 3500, false));
            fleet.Add(GenerateAirlplane("A07", 54, 3500, false));
            fleet.Add(GenerateAirlplane("A08", 54, 4000, false));
            fleet.Add(GenerateAirlplane("A09", 54, 3500, false));
            fleet.Add(GenerateAirlplane("A10", 54, 3500, true));

            return fleet;
        }        
    }
}
