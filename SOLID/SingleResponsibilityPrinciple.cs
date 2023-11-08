using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID
{
    public class Single_Responsibility_Principle
    {
        //Only one reason to change. Class should have only one responsibility.
    }

    //Incorrect Example, violating SRP
    public class Bike
    {
        public int Wheels { get; set; }
        public string Name { get; set; }

        public void Wash()
        {
            Console.WriteLine("Washing bike...");
        }
        public void Ride()
        {
            Console.WriteLine("Heavy cycling...");
        }
        public void Respray(string color)
        {
            Console.WriteLine($"Bike {Name} will get new {color} color.");
        }
    }

    //Correct Usage
    public class Bike2
    {
        public int Wheels { get; set; }
        public string Name { get; set; }
        public void Ride()
        {
            Console.WriteLine("Heavy cycling...");
        }
    }

    public class ValetingBay
    {
        public void Wash(Bike2 bike)
        {
            Console.WriteLine($"Bike: {bike.Name} is under wash process");
        }
    }

    public class RevampGarage
    {
        public void Respray(Bike2 bike, string color)
        {
            Console.WriteLine($"Bike {bike.Name} will get new {color} color.");
        }
    }
}
