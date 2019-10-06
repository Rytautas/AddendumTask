using System;
using System.Collections.Generic;
using System.Text;

namespace AddendumTask
{
    class ConsoleUserInterface
    {
        public DateTime[] init()
        {
            string input;

            Console.WriteLine("Enter search period start date (YYYY/MM/DD):");
            input = Console.ReadLine();
            DateTime.TryParse(input, out DateTime lowerBound);

            Console.WriteLine("Enter search period end date (YYYY/MM/DD):");
            input = Console.ReadLine();
            DateTime.TryParse(input, out DateTime upperBound);

            return new DateTime[2] { lowerBound, upperBound };
        }
    }
}
