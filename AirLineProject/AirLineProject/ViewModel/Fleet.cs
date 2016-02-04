using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model
{
    public class Fleet
    {
        public Aircraft GenerateAirlplane(string aircraftID, int capacity, int range, bool maintstatus)
        {
            return (new Aircraft(aircraftID, capacity, range, maintstatus));
        }
        public List<Aircraft> BuildInitalFleet()
        {
            List < Aircraft > fleet = new List<Aircraft>(); 
            fleet.Add(GenerateAirlplane("A01", 240, 4000, false));
            fleet.Add(GenerateAirlplane("A02", 240, 4000, true));
            fleet.Add(GenerateAirlplane("A03", 180, 3500, true));
            fleet.Add(GenerateAirlplane("A04", 180, 3500, true));
            fleet.Add(GenerateAirlplane("A05", 180, 3500, true));
            fleet.Add(GenerateAirlplane("A06", 240, 3500, true));
            fleet.Add(GenerateAirlplane("A07", 180, 3500, true));
            fleet.Add(GenerateAirlplane("A08", 180, 4000, true));
            fleet.Add(GenerateAirlplane("A09", 240, 3500, true));
            fleet.Add(GenerateAirlplane("A10", 180, 3500, false));

            return fleet;
        }        
    }
}
