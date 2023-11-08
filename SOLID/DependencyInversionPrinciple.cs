using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class DependencyInversionPrinciple
    {
        //Would you solder a lamp to socket in a wall?
        // High-level modules should not depend on low-level. Both should depend on abstractions. Abstractions should not rely on details.
        // Details should depend upon abstractions
    }
    //Violates DIP
    public class LightBulb
    {
        public void TurnOn()
        {
            Console.WriteLine("It's ON");
        }
        public void TurnOff()
        {
            Console.WriteLine("It's OFF");
        }
    }
    public class Switch
    {
        private LightBulb _bulb;
        public Switch()
        {
            _bulb = new LightBulb();
        }
        //High-level modules depends on low-level
        public void Operate()
        {
            _bulb.TurnOn();
            _bulb.TurnOff();
        }
    }
    //Correct Examply
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }
    public class LightBulb2 : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("It's ON");
        }
        public void TurnOff()
        {
            Console.WriteLine("It's OFF");
        }
    }
    public class Switch2
    {
        private ISwitchable _switchable;
        public Switch2(ISwitchable switchableDevice)
        {
            _switchable = switchableDevice;
        }
        //depends on abstraction - implemented interface
        public void Operate()
        {
            _switchable.TurnOn();
            _switchable.TurnOff();
        }
    }
}
