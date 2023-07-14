using System;

namespace Abstraction.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW myCar = new BMW(); // Create a BMW object
            myCar.CarModel();  // Call the abstract method
            myCar.Year();  // Call the regular method

            // Write code here


            Console.ReadKey( );
        }
    }
}
