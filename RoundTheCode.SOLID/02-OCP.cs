using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.SOLID.OSP
{
    // OPEN/CLOSED PRINCIPAL

    // Adding abstract vehicle class and putting the Wheels property
    public abstract class Vehicle
    {
        public int Wheels { get; set; }
    }

    // Inherit the Vehicle class to give access to the Wheels Property
    public class Car : Vehicle
    {
        //public int Wheels { get; set; }
    }

    // Inherit the Vehicle class to give access to the Wheels Property
    public class Motorbike : Vehicle
    {
       //public int Wheels { get; set; }
    }

    public class Wheel
    {
        public int CountTotalWheels(Vehicle[] vehicles)
        {
            var wheelCount = 0;

            foreach (var vehicle in vehicles)
            {
                wheelCount += vehicle.Wheels;

                /// Remove code below as it doesn't need to be specific to a type of vehicle 
                /// and now we can add more types of vehicles like Bus class
                //if (vehicle is Car)
                //{
                //    wheelCount += ((Car)vehicle).Wheels;
                //}
                //if (vehicle is Motorbike)
                //{
                //    wheelCount += ((Motorbike)vehicle).Wheels;
                //}                
            }

            return wheelCount;
        }
    }
}
