﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class EvenValueFibbonacciNumbers
    {
        public EvenValueFibbonacciNumbers() { }

        /*
         * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

            1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

            By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
         */

        /*
         * Debo primero que todo encontrar los n-simos numeros de fibonacci hasta 1 millon
         * I dont want use arrays or lists because they would be very big and expensives.
         * 
         * My proposal consist in next steps:
         * 1. A while increment from 1 to 1 000 000
         * 2. A condition checking if the index number from while is a fibonacci number or not.
         * 2.a A number x is a fibbonacci number if and only if 5x^2 + 4 or 5x^2 - 4 is a perfect square
         * 2.b How to check if a number is a perfect square?
         * 3. A condition checking if the fibanaci number is even, if it is true, then sum+=indexNumber.
         */
        
        public int Sol2(int upperLimit = 4000000)
        {
            int[] head = { 1, 2 };
            int sum = 0;
            while (true)
            {
                if (!((head[1] & 1) == 1))
                {
                    // Number is even (par)
                    sum += head[1];
                }

                // last mid curr
                int last_prev = head[0];
                head[0] = head[1];                
                head[1] += last_prev;
                //Console.WriteLine(head[1]);

                if (head[1] > upperLimit) break;                
            }
            return sum;
        }

        public int Sol(int upperLimit=4000000)
        {
            int i = 1;
            int sum = 0;
            Console.WriteLine(!((35123 & 1) == 1));
            while (i <= upperLimit)
            {
                // Is it a fibbonacci number?
                if (isAFibbonacciNumber(i))
                {
                    //Console.WriteLine(i);

                    // Is it a even number?
                    if (!((i & 1) == 1))
                    {
                        // The number is even (par) then add to sum.
                        Console.WriteLine(i);
                        sum += i;
                    }
                }
                i++;
            }
            return sum;
        }

        public bool isAFibbonacciNumber(int n)
        {
            double eqTest1 = 5 * n * n + 4;
            double eqTest2 = 5 * n * n - 4;
            return isPerfectSquare(eqTest1) || isPerfectSquare(eqTest2);
        }

        // I should search for an more optime solution for compute square roots
        private bool isPerfectSquare(double n)
        {
            // Check equallity in floating point number is so disturbing for me.
            double s = Math.Floor( Math.Sqrt(n) );
            double diff = Math.Abs((s * s) - n);
            return diff < 0.01;
        }
    }
}
