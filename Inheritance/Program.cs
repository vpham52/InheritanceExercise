using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class


            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class             *  
             *  
             * Creatively display the class member values 
             */

            var penguin = new Bird()
            {
                AnimalName = "Penguin",
                HasFeathers = true,
                NumberOfWings = 2,
                CanFly = true,
                HasBeak = true,
                EggsOrBabies = "Eggs",
                
            };

            var iguana = new Reptile()
            {
                AnimalName = "Iguana",
                TypeOfBlood = "Cold-Blooded",
                HasScales = true,
                Backbone = true,
                HasForkedTongue = true,
                NumbeOfLegs = 4,
            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
       
            iguana.PrintDetails();
            Console.WriteLine();
            penguin.PrintDetails();


        }
    }
}
