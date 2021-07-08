using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zavatta;

namespace UnitTest
{
    [TestClass]
    public class TestEnemy
    {
        
        private const int VEHICLE_SCROLL = 1;
        private const int CAR_SPEED = 2;
        private const int TRUCK_SPEED = 1;
        private const int TRAIN_SPEED = 10;
        private const int RANDOM_SPEED_ADDITION = 10;
        private const int RANDOM_XLOCSPAWN_ADDITION = 1500;

        [TestMethod]
        public void TestCar()
        {
            IVehicle vehicle = new Vehicle();
            vehicle.InitializeCar(4);
            Assert.IsTrue(vehicle.GetVehicleType == VehicleType.TRUCK || vehicle.GetVehicleType == VehicleType.CAR);
            Assert.IsTrue(vehicle.GetVehicleSpeed >= TRUCK_SPEED
                    && vehicle.GetVehicleSpeed <= CAR_SPEED + RANDOM_SPEED_ADDITION);
            Assert.IsTrue(vehicle.VehicleXLocSpawn >= TRUCK_SPEED
                    && vehicle.VehicleXLocSpawn <= CAR_SPEED * RANDOM_XLOCSPAWN_ADDITION);
        }

        [TestMethod]
        public void TestTrain()
        {
            IVehicle vehicle = new Vehicle();
            vehicle.InitializeTrain(4);
            Assert.AreEqual(VehicleType.TRAIN, vehicle.GetVehicleType);
            Assert.IsTrue(vehicle.GetVehicleSpeed >= TRAIN_SPEED
                    && vehicle.GetVehicleSpeed <= TRAIN_SPEED + RANDOM_SPEED_ADDITION);
            Assert.IsTrue(vehicle.VehicleXLocSpawn >= TRAIN_SPEED
                    && vehicle.VehicleXLocSpawn <= TRAIN_SPEED * RANDOM_XLOCSPAWN_ADDITION);
        }
    }
}
