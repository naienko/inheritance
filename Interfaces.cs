using System;
using System.Collections.Generic;

namespace gary_garage {
	 public interface IElectricPowered {
        double BatteryKWh { get; }

        void ChargeBattery();
    }

	public interface IGasPowered {
		double FuelCapacity { get; }
		void RefuelTank();
	}
}