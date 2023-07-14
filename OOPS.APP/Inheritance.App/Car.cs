using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.App
{
    // inheritance allows us to create a new class from an existing class
    public class Car // base class (parent) 
    {
        public string brand = "Ford"; // Car field

        public void honk() // Car method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
