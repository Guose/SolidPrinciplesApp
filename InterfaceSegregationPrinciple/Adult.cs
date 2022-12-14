using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    // An adult can turn things on and off AND they can drive
    public class Adult
    {
        public void Drive(IDriveable vehicle)
        {
            Console.WriteLine("Adult is about to drive.");
            vehicle.Drive();
            Console.WriteLine("Adult is done driving.");
        }

        public void TurnOnDevice(ITurnOn device)
        {
            Console.WriteLine("Adult is about to turn on the device.");
            device.TurnOn();
            Console.WriteLine("Adult is done turning on the device.");
        }

        public void TurnOffDevice(ITurnOff device)
        {
            Console.WriteLine("Adult is about to turn off the device.");
            device.TurnOff();
            Console.WriteLine("Adult is done turning off the device.");
        }
    }
}
