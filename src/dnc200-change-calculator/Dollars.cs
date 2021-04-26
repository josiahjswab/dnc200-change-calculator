using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Dollars : IRemainder
    {
        double change;
        double dollar = 1;

        public Dollars(double _change)
        {
            change = _change;
        }
        public double Remainder()
        {
            double result = change % dollar;
            return result;
        }

        public double Change()
        {
            double floor = Math.Floor(change);
            return floor;
        }
    }
}