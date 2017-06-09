using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            multiplos3y5 prob1 = new multiplos3y5();     
            prob1.whileSol();

            EvenValueFibbonacciNumbers prob2 = new EvenValueFibbonacciNumbers();
            Console.WriteLine(prob2.Sol());

            Console.ReadKey();
        }
    }
}
