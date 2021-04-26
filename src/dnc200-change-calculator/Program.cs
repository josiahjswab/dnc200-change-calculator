using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double cost, tender, dollars, quarters, dimes, nickles, pennies;

            Console.WriteLine("Total Cost?");
            cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total Tender?");
            tender = Convert.ToDouble(Console.ReadLine());

            double change = tender - cost;
            Console.WriteLine($"C-T+Change{cost}-{tender}={change}");
            Console.Clear();

            Dollars dollar = new Dollars(change);
            Quarters quarter = new Quarters(dollar.Remainder());
            Dimes dime = new Dimes(quarter.Remainder());
            Nickles nickle = new Nickles(dime.Remainder());
            Pennies penny = new Pennies(nickle.Remainder());

            dollars = dollar.Change();
            quarters = quarter.Change();
            dimes = dime.Change();
            nickles = nickle.Change();
            pennies = penny.Change();

            Console.WriteLine("Change due breakdown:");
            Console.WriteLine($"Dollars:{dollars}");
            Console.WriteLine($"Quarters:{quarters}");
            Console.WriteLine($"Dimes:{dimes}");
            Console.WriteLine($"Nickles:{nickles}");
            Console.WriteLine($"Pennies:{pennies}");

        }
        public double GetChange(double cost, double tender)
        {
            return 
        }
    }
}
