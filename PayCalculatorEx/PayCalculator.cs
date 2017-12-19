using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculatorEx
{
    class PayCalculator
    {
        string hours;
        string rate;

        private string DisplayHours()
        {
            Console.WriteLine("Plase enter your hours");
            string numberHours = Console.ReadLine();
            /*Console.ReadKey();*/
            return numberHours;
        }
        private string Displayrate()
        {
            Console.WriteLine("Please enter your rate");
            string howMuchPaid = Console.ReadLine();
            /*Console.ReadKey();*/
            return howMuchPaid;
        }
        public float CalculatePay()
        {
            hours = DisplayHours();
            rate = Displayrate();

            float hoursTotal = float.Parse(hours);
            float rateTotal = float.Parse(rate);
            float pay = hoursTotal * rateTotal;
            return pay;

        }
        public void DisplayResults()
        {
          float results = CalculatePay();
            Console.WriteLine("Your pay is: {0}, good job", results);
            Console.ReadKey();
        }
    }
}
