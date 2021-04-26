using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Quarters : IRemainder
    {
        double change;
        double quarter = 25;

        public Quarters(double _change)
        {
            change = _change * 100;
        }
        public double Remainder()
        {

            double result = change % quarter;
            return result;
        }

        public double Change()
        {
            double remainder = (change - Remainder());
            return remainder / quarter;
        }
        
    }
}