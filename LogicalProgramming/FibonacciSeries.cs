using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming 
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter length of Series - ");
            int length = Convert.ToInt32(Console.ReadLine());
            int firstnumber = 0, secondnumber = 1, result = 0;
            Console.WriteLine(firstnumber + "\n" + secondnumber);
            for (int i = 0; i < length; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
                Console.WriteLine(result);

            }
        }
    }
}