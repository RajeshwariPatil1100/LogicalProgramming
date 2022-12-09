using LogicalProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming 
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Logical Programming Problems");
                Console.WriteLine("1.Fibonacci Series" + "\n" + "2.Perfect Number" + "\n" + "3.prime number" + "\n" + "4.Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:

                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber num = new PerfectNumber();
                        num.Perfect();
                        break;
                    case 3:
                        PrimeNumber number = new PrimeNumber();
                        number.Prime();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}