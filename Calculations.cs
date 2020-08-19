using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderwiseCalculator
{
    public class Calculations
    {
        public double value {get; set; }
        public double number { get; set; }
        public string Calculation { get; set; }
        public bool op { get; set; }
        public bool isDecimal { get; set; }


        public static double Addition(double value, double number)
        {
            return value + number;
        }

        public static double Substrction(double value, double number)
        {
            return value - number;
        }

        public static double Multiplication(double value, double number)
        {
            return value * number;
        }
        public static double Division(double value, double number)
        {
            return value / number;
        }

        public static double Percentage(double value, double number)
        {
            return value / number * 100;
        }

    }
}
