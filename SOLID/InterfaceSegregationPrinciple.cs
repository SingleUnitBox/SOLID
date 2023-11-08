using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class InterfaceSegregationPrinciple
    {
        //Class should not be forced to implement interfaces is does not use
    }
    //Violates ISP
    public interface IWorker
    {
        void Eat();
        void Work();
    }
    public class Worker : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
    public class Robot : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("I do not need to eat but I have to due IWorker interface");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
    //Correct Use
    public interface IWorker2
    {
        void Work();
    }
    public interface IEater2
    {
        void Eat();
    }
    public class Worker2 : IWorker2, IEater2
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
    public class Robot2 : IWorker2
    {
        public void Work()
        {
            Console.WriteLine("Only work");
        }
    }
}
