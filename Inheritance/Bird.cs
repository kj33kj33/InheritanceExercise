using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

		public string BirdName { get; set; }
		public double BeakLength { get; set; }
		public string Color { get; set; }
		public bool LaysMultipleEggs { get; set; }
	}
}

