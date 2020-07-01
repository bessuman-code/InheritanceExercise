using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {

        }
        public void ReptileMovement()
        {
            Console.WriteLine("Two hind legs, two front legs");
        }
        public void ReptileMouth()
        {
            Console.WriteLine("Sharp teeth");
        }
        public void ReptileFood()
        {
            Console.WriteLine("Animals");
        }
        public void ReptileHome()
        {
            Console.WriteLine("Land and water");
        }
    }
}
