using System;

namespace Inheritance.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Ford myCar = new Ford();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Console.ReadKey();
        }
    }
}
