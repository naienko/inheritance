using System;
using System.Collections.Generic;

namespace gary_garage
{
	class Program
	{
		static void Main()
		{

			Zero fxs = new Zero() {
                BatteryKWh = 5,
                MaximumOccupancy = "2"
            };
            
			Tesla modelS = new Tesla() {
                BatteryKWh = 15,
                MaximumOccupancy = "4"
            };
			Cessna mx410 = new Cessna() {
                FuelCapacity = 8,
                MaximumOccupancy = "4"
            };
            Ram dodge = new Ram() {
                FuelCapacity = 15,
                MaximumOccupancy = "7"
            };

            fxs.MainColor = "red";
            modelS.MainColor = "silver";
            mx410.MainColor = "white";
            dodge.MainColor = "black";

			fxs.Drive();
			modelS.Drive();
			mx410.Drive();
            dodge.Drive();

            List<Vehicle> allVehicles = new List<Vehicle>() {
                fxs, modelS, mx410, dodge
            };

            foreach (Vehicle vehicle in allVehicles) {
                vehicle.Stop();
            }
            allVehicles.ForEach(v => v.Turn("left"));
		}
	}
}
