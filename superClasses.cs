using System;

namespace gary_garage
{
	public class Vehicle
	{
		public string MainColor { get; set; }
		public string MaximumOccupancy { get; set; }
		public virtual void Drive() {
			Console.WriteLine("Vroooom!");
		}
		public virtual void Turn(string direction) {
			Console.WriteLine($"The vehicle carefully makes a {direction}-hand turn.");
		}
		public virtual void Stop() {
			Console.WriteLine("The vehicle slowly comes to a stop.");
		}
	}
}