using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Let's Reverse the given Number");
            Console.WriteLine("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (number != 0)
            {
                int reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number /= 10;   //n = n/10
            }
            Console.WriteLine("Reverse of given number is " + reverse);
        }
    }
}
