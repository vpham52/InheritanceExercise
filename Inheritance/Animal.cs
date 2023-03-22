using System;
namespace Inheritance
{
	public class Animal
	{
		public Animal()
		{
		}

		public int NumbeOfLegs { get; set; }
		public bool HasATail { get; set; }
		public bool HasFur { get; set; }
		public string EggsOrBabies { get; set; } //eggs or live babies
        public string AnimalName { get; set; } //eggs or live babies


   //     public void PrintDetails()
   //     {
			//Console.WriteLine($"{GetType().Name} Class");
			//Console.WriteLine($"Name: {AnimalName}");
			//Console.WriteLine($"Tail:{HasATail}");
   //         Console.WriteLine($"Number of Legs: {NumbeOfLegs}");
   //         Console.WriteLine($"Eggs or Babies?: {EggsOrBabies}");


   //     }

    }
}

