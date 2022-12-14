using System;

namespace InterfaceSegregationPrinciple
{
    // The light switch can only be turned on and off
    public class LightSwitch : ITurnOff, ITurnOn
    {
        public void TurnOff()
        {
            Console.WriteLine("Light switch is turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Light switch is turned on");
        }
    }
}
