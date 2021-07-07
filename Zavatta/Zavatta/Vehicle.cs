using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavatta
{
    /// <summary>
    /// The implementation of the Interface Vehicle.
    /// </summary>
    public class Vehicle :  Box, IVehicle
    {

        private const int MAP_SCROLL = 1;
        private const int HIGHER_LIMIT = 900;
        private const int INFERIOR_LIMIT = -100;
        private const int CAR_SPEED = 2;
        private const int TRUCK_SPEED = 1;
        private const int TRAIN_SPEED = 10;
        private const int RANDOM_SPEED_ADDITION = 10;
        private const int RANDOM_XLOCSPAWN_ADDITION = 1500;

        private Random rand = new Random();
        private int vehicleSpeed;
        private int vehicleXLocSpawn;
        private VehicleType type;

        public IVehicle InitializeCar(double stripYLoc)
        {

            this.YDir=(MAP_SCROLL);
            this.YLoc=(stripYLoc);

            if (rand.Next(2) == 1)
            {
                 this.SetRndDir(CAR_SPEED, "Car_Left.png", "Car_Right.png");
                 this.type = VehicleType.CAR;
            }
            else
            {
                this.SetRndDir(TRUCK_SPEED, "Truck_L.png", "Truck_R.png");
                this.type = VehicleType.TRUCK;
            }
            return this;
        }


        public IVehicle InitializeTrain(double stripYLoc)
        {

            this.YDir=(MAP_SCROLL);
            this.YLoc=(stripYLoc);
            this.SetRndDir(TRAIN_SPEED, "Train.png", "Train.png");
            this.type = VehicleType.TRAIN;

            return this;
        }


        public void SetRndDir(int speed, string imgR, string imgL)
        {

            vehicleSpeed = rand.Next(RANDOM_SPEED_ADDITION) + speed;
            vehicleXLocSpawn = rand.Next(RANDOM_XLOCSPAWN_ADDITION) * speed;


            if (rand.Next(2) == 1)
            {
                this.XLoc=(vehicleXLocSpawn + HIGHER_LIMIT);
                this.XDir=(-(vehicleSpeed));
                this.SetImage(imgR);

            }
            else
            {
                this.XLoc = (-vehicleXLocSpawn - INFERIOR_LIMIT);
                this.XDir = (vehicleSpeed);
                this.SetImage(imgL);
            }
        }

        public IVehicle GetVehicle { get => this; }

        public VehicleType GetVehicleType { get => this.type; }

        public int GetVehicleSpeed{ get => this.vehicleSpeed; }

        public int VehicleXLocSpawn { get => this.vehicleXLocSpawn; }

    }

}
