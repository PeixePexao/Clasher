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
            double[] xvxmu = new double[10000];
            for (int i = 0; i < 10000; i++)
            {
                quadrados[i] = Math.Pow(i, 2);
                
            }
            Console.WriteLine("Quadrados Gerados!");
            System.Threading.Thread.Sleep(2000);
            for (int i = 0; i < 10000; i++)
            {
                xvxmu[i] = Math.Pow(i, 2) + Math.Pow(i - 1, 2);
            }
            Console.WriteLine("x² + (x - 1)² gerados!");
            System.Threading.Thread.Sleep(2000);
            var intersect = quadrados.Intersect(xvxmu);

            foreach(double res in intersect)
            {
                Console.WriteLine(res);
            }

            
        }

    }
}
