using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavatta
{
    public interface IVehicle
    {
        /// <summary>
        /// Randomly create a car or truck and set his own position and direction.
        /// <param name="stripYLoc"> contains the line where the vehicle will be printed </param>
        /// <returns> get the vehicle      
        IVehicle InitializeCar(double stripYLoc);

        /// <summary>
        /// Call the methods for sets the position and direction of the train.
        /// <param name="stripYLoc"> contains the line where the train will be printed
        /// <returns> get the train
        IVehicle InitializeTrain(double stripYLoc);

        /// <summary>
        /// Sets randomly the position and direction of the vehicles.
        /// <param name="speed">   speed of the vehicle.
        /// <param name="imgR">   right sprite of the vehicle.
        /// <param name="imgL">   left sprite of the vehicle.
        void SetRndDir(int speed, string imgR, string imgL);

        /// <summary>
        /// return the vehicle.
        /// <returns> get the vehicle
        IVehicle GetVehicle { get; }

        /// <summary>
        /// return the vehicle type.
        /// <returns> get the vehicle type
        VehicleType GetVehicleType { get; }

        /// <summary>
        ///  return the vehicle speed.
        /// <returns> the speed of the vehicle
        int GetVehicleSpeed { get; }

        /// <summary>
        ///  return the vehicle's X spawn position.
        /// <returns> the vehicle's X spawn position
        int VehicleXLocSpawn { get; }
    }
}
