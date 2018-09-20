using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool duiBool;
            if (dui.ToLower().Equals("no"))
            {
                duiBool = true;
            }
            else
            {
                duiBool = false;
            }

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool qualified = (age > 15) && (duiBool == true) && (tickets <= 1);
            Console.WriteLine(qualified);
            Console.ReadLine();

        }
    }
}
