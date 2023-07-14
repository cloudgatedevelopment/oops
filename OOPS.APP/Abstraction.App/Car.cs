using System;

namespace Abstraction.App
{
    // Abstract class
    /// <summary>
    /// Data abstraction is the process of hiding certain details
    /// and showing only essential information to the user.
    /// 
    /// Abstract class: is a restricted class that cannot be used 
    /// to create objects (to access it, it must be inherited
    /// from another class).
    /// 
    /// Car obj = new Car(); // Will generate an error
    /// (Cannot create an instance of the abstract class or interface 'Car')
    /// 
    /// Abstract method: can only be used in an abstract class,
    /// and it does not have a body.The body is provided by
    /// the derived class (inherited from).
    /// </summary>
    abstract class Car
    {
        // Abstract method (does not have a body)
        public abstract void CarModel();

        // Regular method
        public void Year()
        {
            Console.WriteLine($"Car Year : {DateTime.Now.Year}");
        }
    }
}
