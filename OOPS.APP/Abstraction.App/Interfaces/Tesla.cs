using System;

namespace Abstraction.App.Interfaces
{
    public class Tesla : ICar
    {
        public void CarModel()
        {
            Console.WriteLine("Tesla Model S with 'ICar' interface.");
        }

        public void Year()
        {
            Console.WriteLine($"Tesla Car Year : {DateTime.Now.Year} with 'ICar' interface.");
        }
    }
}
