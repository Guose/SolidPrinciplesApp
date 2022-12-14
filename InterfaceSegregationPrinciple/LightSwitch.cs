using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
