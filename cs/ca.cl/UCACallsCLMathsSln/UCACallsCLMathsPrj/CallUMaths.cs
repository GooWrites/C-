using System;
using UCLPrjMaths;

namespace UCACallsCLMathsPrj
{
    class CallUMaths
    {
        static void Main(string[] args)
        {
            UCLsArithmetic uca = new UCLsArithmetic();

            double d1 = uca.USum (0.5, 9);
            double d2 = UCLsArithmetic.UMinus(8, 3);

            double d3 = 0;
            uca.UMultiply(0.7, 10, out d3);
            double d4 = 0;
            UCLsArithmetic.UDivide(10, 3, out d4);

            uca.USquare = 8;
            UCLsArithmetic.UCube = 5;
            UCLsSum ucs = new UCLsSum();
            ucs[0] = 11;
            ucs[2] = 33;
            ucs[4] = 55;

            double[] darr = ucs.UElements;

            Console.WriteLine(d1 + ", " + d2);
            Console.WriteLine(d3 + ", " + d4);

            foreach (double d in darr)
            {
                Console.WriteLine(d);
            }


        }
    }
}

/*
 * 9.5, 5
7, 3.33333333333333
11
33
55
Press any key to continue . . .
*/