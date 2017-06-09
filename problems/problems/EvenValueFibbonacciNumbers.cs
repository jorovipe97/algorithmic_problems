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
        public int Sol(int upperLimit=4000000)
        {
            int i = 1;
            int sum = 0;
            while (i < upperLimit)
            {
                float eqTest1 = 5*i*i + 4;
                float eqTest2 = 5*i*i - 4;
                if (isPerfectSquare(eqTest1) || isPerfectSquare(eqTest2))
                {
                    
                    if ((i & 1) == 1)
                    {
                        // The number is even then add to sum.
                        //Console.WriteLine(i);
                        sum += i;
                    }
                }
                i++;
            }

            return sum;
        }

        // I should search for an more optime solution for compute square roots
        private bool isPerfectSquare(float n)
        {
            return (Math.Sqrt(n) - (int)Math.Sqrt(n)) == 0;
        }
    }
}