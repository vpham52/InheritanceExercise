using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

		public string TypeOfBlood { get; set; } = "Cold-Blooded";
		public bool HasScales { get; set; } = true;
		public bool Backbone { get; set; }
        public bool HasForkedTongue { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name} Class");
            Console.WriteLine($"Name: {AnimalName}");
            Console.WriteLine($"Type of Blood: {TypeOfBlood}");
            Console.WriteLine($"Scales: {HasScales}");
            Console.WriteLine($"Backbone: {Backbone}");
            Console.WriteLine($"Forked Tongue: {Backbone}");
            Console.WriteLine($"Number of Legs: {NumbeOfLegs}");


        }
    }
}

