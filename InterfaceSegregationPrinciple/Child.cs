using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    // A child can only turn things on, they can't turn them off again, and they certainly can't drive
    public class Child
    {
        public void TurnOnDevice(ITurnOn device)
        {
            Console.WriteLine("Child is about to turn on the device.");
            device.TurnOn();
            Console.WriteLine("Child is done turning on the device.");
        }
    }
}
