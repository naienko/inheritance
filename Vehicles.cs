using System;

namespace gary_garage
{

	public class Zero : Vehicle, IElectricPowered
	{  // Electric motorcycle
		public double BatteryKWh { get; set; }
		public void ChargeBattery()
		{
			Console.WriteLine($"The Zero is charged to {this.BatteryKWh}KWh");
		}
		public override void Drive() {
			Console.WriteLine($"The {MainColor} Zero shoots past you. Vroooooom!");
		}
	}
	public class Cessna : Vehicle, IGasPowered
	{  // Propellor light aircraft
		public double FuelCapacity { get; set; }
		public void RefuelTank()
		{
			Console.WriteLine("Refilling gas tank.");
		}
		public override void Drive() {
			Console.WriteLine($"The {MainColor} Cessna takes off over you. Zooom! (whoosh ...)");
		}
		public override void Stop() {
			Console.WriteLine($"The {MainColor} Cessna rolls to a stop along the runway.");
		}
	}
	public class Tesla : Vehicle, IElectricPowered
	{  // Electric car
		public double BatteryKWh { get; set; }
		public void ChargeBattery()
		{
			Console.WriteLine($"The Tesla is charged to {this.BatteryKWh}KWh");
		}
		public override void Drive() {
			Console.WriteLine($"The {MainColor} Tesla slips past you in silence.");
		}
		public override void Turn(string direction) {
			Console.WriteLine($"The {MainColor} Tesla swings into a {direction} turn.");
		}
	}
	public class Ram : Vehicle, IGasPowered
	{  // Gas powered truck
		public double FuelCapacity { get; set; }
		public void RefuelTank()
		{
			Console.WriteLine("Refilling gas tank.");
		}
		public override void Drive() {
			Console.WriteLine($"The {MainColor} Ram roars past you. RRummmble!");
		}
		public override void Stop() {
			Console.WriteLine($"The {MainColor} Ram grinds to a stop.");
		}
	}
}