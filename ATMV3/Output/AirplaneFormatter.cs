﻿using ATMV3.Interfaces;

namespace ATMV3.Output
{
    class AirplaneFormatter: IVehicleFormatter
    {
        public string vehicleToString(IVehicle plane)
        {
            string general = "Tag: " + plane.Tag + "Coordinates: " + plane.X + "," + plane.Y + "," + plane.Z + "Direction:" + plane.Direction;
            string date = " Date: " + plane.Timestamp.Day + "/" + plane.Timestamp.Month + "-" +
                          plane.Timestamp.Year + "  " + plane.Timestamp.Hour + ":" + plane.Timestamp.Minute + ":" +
                          plane.Timestamp.Second + ":" + plane.Timestamp.Millisecond;
            string airplaneString = general + date +"\n\r";
            return airplaneString;
        }
    }
}
