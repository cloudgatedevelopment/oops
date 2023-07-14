using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.App
{
    // Derived class (inherit from Car)
    class BMW : Car
    {
        public override void CarModel()
        {
            // The body of CarModel() is provided here
            Console.WriteLine("Car Model : BMW 3 Series");
        }
    }
}
