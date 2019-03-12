using System.Collections.Generic;

namespace ATMV3.Interfaces
{
    interface IOutput
    {
        IVehicleFormatter Formatter { get; set; }
        void LogVehicleData(List<IVehicle> v);
    }
}
