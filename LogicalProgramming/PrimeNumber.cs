using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
        internal class PrimeNumber
        {
            public void Prime()
            {
                Console.WriteLine("Let's check given input is Prime or not");
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                int result = number / 2;
                bool IsPrime = true;//represents a Boolean value, which can be either true or false
                for (int i = 2; i < result; i++)
                {
                    if (i % 2 == 0)

                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.WriteLine(number + " is Prime Number ");
                }
                else
                {
                    Console.WriteLine(number + " is not Prime Number");
                }
            }
        }
}
