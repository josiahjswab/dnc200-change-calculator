using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Pennies
    {
        double change;
        double pennies = 1;

        public Pennies(double _change)
        {
            change = _change;
        }
        public double Remainder()
        {

            double result = change % pennies;
            return result;
        }

        public double Change()
        {
            double remainder = (change - Remainder());
            return remainder / pennies;
        }
    }
}