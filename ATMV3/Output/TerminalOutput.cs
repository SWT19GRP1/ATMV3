using System;
using System.Collections.Generic;
using ATMV3.Interfaces;

namespace ATMV3.Output
{
    public class TerminalOutput:IOutput
    {
        public TerminalOutput(IVehicleFormatter formatter)
        {
            Formatter = formatter;
        }
        public IVehicleFormatter Formatter { get; set; }

        public void LogVehicleData(List<IVehicle> vehicles)
        {
            Console.Clear();
            Console.WriteLine("Current Airplanes in Airspace:");
            foreach (var plane in vehicles)
            {
                Console.Write(Formatter.vehicleToString(plane));
            }
            
        }
    }
}
