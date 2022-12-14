using System;

namespace InterfaceSegregationPrinciple
{
    // A car has the ability to be turned on, turned off AND the ability to be driven
    public class Car : ITurnOn, ITurnOff, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

        public void TurnOff()
        {
            Console.WriteLine("The car has stopped");
        }

        public void TurnOn()
        {
            Console.WriteLine("The car has started");
        }
    }
}
