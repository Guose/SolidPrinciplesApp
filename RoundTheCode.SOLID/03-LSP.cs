using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.SOLID.LSP
{
    // LISKOV SUBSTITUTION PRINCIPAL

    public abstract class Vehicle
    {
        public int Wheels { get; set; }

        // remove the member and create an interface
        //public virtual string? HelmetDesign { get; set; }
    }

    // Add an interface
    public interface IHelmet
    {
        string? HelmetDesign { get; set; }
    }

    public class Car : Vehicle
    {
        // This is against the Liskov principle because this child class should NOT be overriding from the parent class
        //public override string? HelmetDesign => throw new NotImplementedException();
    }

    public class Motorbike : Vehicle, IHelmet
    {
        // Add the helmet design member here and inherit interface since you don't need a helmet to operate a Car
        public string? HelmetDesign { get; set; }
    }

}
