using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Nickles
    {
        double change;
        double nickles = 5;

        public Nickles(double _change)
        {
            change = _change;
        }
        public double Remainder()
        {

            double result = change % nickles;
            return result;
        }

        public double Change()
        {
            double remainder = (change - Remainder());
            return remainder / nickles;
        }
    }
}