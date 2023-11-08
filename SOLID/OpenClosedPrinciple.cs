using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class OpenClosedPrinciple
    {
        //A software modules class is open for extension and closed for modification
    }
    // Incorrect Usage
    public class Salary
    {
        public double Hours { get; set; }
        public double HourlyRate { get; set; }
    }
    public class WageCalculator
    {
        // Violates OCP - to calculate different pay eg. commission WageCalculator has to be changed 
        public double CalculatePay(Salary salary)
        {
            return salary.Hours * salary.HourlyRate;
        }
    }
    // Correct Example
    public interface ICalculatePay
    {
        double CalculatePay();
    }
    public class Salary2 : ICalculatePay
    {
        public double Hours { get; set; }
        public double HourlyRate { get; set; }

        public double CalculatePay()
        {
            return Hours * HourlyRate;
        }
    }
    public class Commission : ICalculatePay
    {
        public double Amount { get; set; }
        public double Bonus { get; set; }

        public double CalculatePay()
        {
            return Amount * Bonus;
        }
    }
    // Any object implementing ICalculatePay can be accepted
    public class WageCalculator2
    {
        public double CalculatePay(ICalculatePay calculatePayItem)
        {
            return calculatePayItem.CalculatePay();
        }
    }
}
