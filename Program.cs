using System;
using System.Linq;
using System.Transactions;

namespace Clasher
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] quadrados = new double[10000];

            for (int i = 0; i < 10000; i++)
            {
                quadrados[i] = Math.Pow(i, 2);

            }
            Console.WriteLine("Quadrados Gerados!");
            System.Threading.Thread.Sleep(2000);
            for (int ii = 0; ii < 10000; ii++)
            {
                double xvxmu = (Math.Pow(ii, 2) + Math.Pow(ii - 1, 2));

                foreach (double x in quadrados)
                {
                    if (xvxmu == x)
                    {
                        Console.WriteLine("Match (" + ii + " , " + Math.Sqrt(x) + ")");
                    }

                }


            }

        }
    }
}
