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
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var newBird = new Bird() { Hair = "Feathers and 2 wings", Legs = 2, Tail = "No tail" };
            Console.WriteLine($"{newBird.Hair} {newBird.Legs}");
            newBird.BirdFood();
            newBird.BirdHome();



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var newReptile = new Reptile() { Hair = "Scales", Legs = 4, Tail = "Long" };
            Console.WriteLine($"{newReptile.Hair} {newReptile.Legs}");
            newReptile.ReptileFood();
            newReptile.ReptileHome();
        }
    }
}
