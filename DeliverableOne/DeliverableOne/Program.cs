using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DeliverableOne
{
    class Program
    {
        // Main
        static void Main(string[] args)
        {
            PrintIntro();
            Numbers();
        }

        // Prints an introduction to the user explaining the program
        static void PrintIntro()
        {
            Console.WriteLine("Hello! In this console application I will ask you to input 3 numbers.\n\n" +
                "This program will total up all three of those numbers and then calculate the average, smallest, and largest amounts.\n\n" +
                "And finally print the total of the three numbers into the following currency's, \nthe US Dollar, the Swedish Krona, the Japanese Yen, and the Thai Baht!\n\n");
        }

        // function that gets the dollar amounts and then converts the amounts
        static void Numbers()
        {
            Console.WriteLine("Please input 3 dollar amounts!");

            //Get first number
            string NumberOne = Console.ReadLine();
            double.TryParse(NumberOne, out double AmountOne);

            while (!double.TryParse(NumberOne, out AmountOne))
            {
                Console.WriteLine("Sorry not a valid input! Please enter an amount.");
                NumberOne = Console.ReadLine();
                double.TryParse(NumberOne, out AmountOne);
            }

            //Get second number
            string NumberTwo = Console.ReadLine();
            double.TryParse(NumberTwo, out double AmountTwo);

            while (!double.TryParse(NumberTwo, out AmountTwo))
            {
                Console.WriteLine("Sorry not a valid input! Please enter an amount.");
                NumberTwo = Console.ReadLine();
                double.TryParse(NumberTwo, out AmountTwo);
            }

            //Get third number
            string NumberThree = Console.ReadLine();
            double.TryParse(NumberThree, out double AmountThree);

            while (!double.TryParse(NumberThree, out AmountThree))
            {
                Console.WriteLine("Sorry not a valid input! Please enter an amount.");
                NumberThree = Console.ReadLine();
                double.TryParse(NumberThree, out AmountThree);
            }

            //Convert Total
            double AmountTotal = AmountOne + AmountTwo + AmountThree;
            Console.WriteLine($"\nThe total is: ${AmountTotal}");

            double AmountAvg = AmountTotal / 3;
            Console.WriteLine($"The average is: ${AmountAvg}");

            double[] AmountArray = { AmountOne, AmountTwo, AmountThree };
            Console.WriteLine($"The largest is: ${AmountArray.Max()}");
            Console.WriteLine($"The smallest is: ${AmountArray.Min()}\n");

            //USD
            Console.WriteLine($"American: {AmountTotal.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");

            //Sweedish
            CultureInfo swk = new CultureInfo("sv-SE");
            Console.WriteLine($"Swedish: {AmountTotal.ToString("c", swk)}");

            //Japanese
            CultureInfo jpy = new CultureInfo("ja-JP");
            Console.WriteLine($"Japanese: {AmountTotal.ToString("c", jpy)}");

            //Thai
            Console.OutputEncoding = Encoding.UTF8;
            RegionInfo regioninfoTH = new RegionInfo("TH");
            CultureInfo thb = new CultureInfo("th-TH");
            Console.WriteLine($"Thai: {AmountTotal.ToString("c", thb)}\n");
        }
    }
}
