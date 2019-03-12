using System;
using System.Collections.Generic;
using ATMV3.Interfaces;

namespace ATMV3.Output
{
    public class LogOutput:IOutput
    {
        public LogOutput(IVehicleFormatter formatter)
        {
            Formatter = formatter;
        }
        public void LogVehicleData(List<IVehicle> vehicles)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            foreach (var plane in vehicles)
            {

                System.IO.File.AppendAllText(path,Formatter.vehicleToString(plane));
            }
        }

        public IVehicleFormatter Formatter { get; set; }
    }
}
