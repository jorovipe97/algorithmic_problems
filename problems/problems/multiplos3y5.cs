using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class multiplos3y5
    {
        public multiplos3y5()
        {

        }

        /*
	Multiples of 3 and 5
	
	If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
	find the sum of all the multiples of 3 or 5 below 1000.
*/

        // Como encuentro los numeros multiplos de 3
        // Como encuentro los numeros multiplos de 5

        /*
        Si quiero resolver este problema usando el concepto de las progresiones aritmeticas debo tener en cuenta antes que nada
        que el resultado que me piden es la suma de la suma de los terminos de dor progresiones.
        a. La de los numeros debajo de 1000 que son multiplos de 3
        b. La suma de los numero debajo de 1000 que son multiplos de 5
        */
        public void whileSol ()
        {
            int sum = 0;
            int number = 0;
            while (number < 1000)
            {

                if (number % 3 == 0 || number % 5 == 0)
                {
                    sum += number;
                    //Console.WriteLine(number);
                }
                number++;
            }
            Console.WriteLine(sum);
        }
    }
}
