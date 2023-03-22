using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

        public bool HasFeathers { get; set; }
		public int NumberOfWings { get; set; }		
        public bool CanFly { get; set; }
        public bool HasBeak { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name} Class");
            Console.WriteLine($"Name: {AnimalName}");
            Console.WriteLine($"Feathers: {HasFeathers}");
            Console.WriteLine($"Number of Wings: {NumberOfWings}");
            Console.WriteLine($"Can it fly?: {CanFly}");
            Console.WriteLine($"Beak: {HasBeak}");
            Console.WriteLine($"Eggs or Babies?: {EggsOrBabies}");


        }
    }
}

