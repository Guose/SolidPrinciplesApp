using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var child = new Child();
            var adult = new Adult();
            var car = new Car();
            var lightSwitch = new LightSwitch();
            
            child.TurnOnDevice(car);
            child.TurnOnDevice(lightSwitch);

            adult.TurnOffDevice(car);
            adult.TurnOffDevice(lightSwitch);
            adult.TurnOnDevice(lightSwitch);
            adult.TurnOnDevice(car);
            adult.Drive(car);
            adult.TurnOffDevice(car);

            Console.ReadLine();
        }
    }
}
