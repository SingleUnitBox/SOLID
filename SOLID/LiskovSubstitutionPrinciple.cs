using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID
{
    public class LiskovSubstitutionPrinciple
    {
        //Parent class object can be replaced of child class w/o affecting correctness of program
    }
    //Incorrect Use
    public class Shrimp
    {
        public string Name { get; set; }
        public string WaterPH { get; set; }
        public virtual void Swim()
        {
            Console.WriteLine($"{Name} swimming...");
        }
            
    }
    public class Caridina : Shrimp
    {
        public string Color { get; set; }
        public override void Swim()
        {
            Console.WriteLine($"{Color} {Name} swimming...");
        }
    }
    public class CookedShrimp : Shrimp
    {
        public DateTime BestBefore { get; }
        public override void Swim()
        {
            //Cooked shrimp cannot swim
            Console.WriteLine("Swimming...");
        }
    }
    //Correct Example
    public interface ISwimmable
    {
        void Swim();
    }
    public class Shrimp2 : ISwimmable
    {        
        public string Name { get; set; }
        public string WaterPH { get; set; }
        public void Swim()
        {
            Console.WriteLine($"{Name} swimming...");
        }
    }
    public class Caridina2 : ISwimmable
    {
        public string Color { get; set; }
        public void Swim()
        {
            Console.WriteLine($"{Color} shrimp swimming...");
        }
    }
    public class CookedShrimp2 : ISwimmable
    {
        public DateTime BestBefore { get; }

        public void Swim()
        {
            Console.WriteLine("I cannot swim...");
        }
    }

    public class Client
    {
        public void MakeShrimpSwim(ISwimmable swimmableShrimp)
        {
            swimmableShrimp.Swim();
        }
    }
}
