using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Dimes : IRemainder
    {
        double change;
        double dime = 10;

        public Dimes(double _change)
        {
            change = _change;
        }
        public double Remainder()
        {

            double result = change % dime;
            return result;
        }

        public double Change()
        {
            double remainder = (change - Remainder());
            return remainder / dime;
        }
    }
}