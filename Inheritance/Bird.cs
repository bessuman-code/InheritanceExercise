using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird()
        {

        }
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public void BirdMovement()
        {
            Console.WriteLine("Two legs, two wings and can fly");
        }
        public void BirdMouth()
        {
            Console.WriteLine("Like a beak");
        }
        public void BirdFood()
        {
            Console.WriteLine("Insects and plants");
        }
        public void BirdHome()
        {
            Console.WriteLine("Land");
        }
    }
}
