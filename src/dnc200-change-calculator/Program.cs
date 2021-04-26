using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double cost, tender;

            Console.WriteLine("Total Cost?");
            cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total Tender?");
            tender = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(GetChange(cost, tender));
        }
        
        public static string GetChange(double _cost, double _tender)
        {
            double dollars, quarters, dimes, nickles, pennies;

            double change = _tender - _cost;
            Console.WriteLine(change);

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

            if(change == 0) {
                return "No change is due";
            };
            if(change < 0) {
                return "You are still owed";
            };
            if(change > 0) {
                string[] changeArr = {"The total change due is", $"{dollars} dollars", $"{quarters} quarters", $"{dimes} dimes", $"{nickles} nickles", $"{pennies} pennies"};

                for(int i = 0; i < changeArr.Length; i++) 
                {
                    Console.WriteLine(changeArr[i]);
                }
                return changeArr[0];
            };

            return "Something";
        }
    }
}
