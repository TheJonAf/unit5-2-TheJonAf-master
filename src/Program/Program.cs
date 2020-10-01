using System;
using System.Threading;
using System.Transactions;

namespace ITSS131
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.Write("How many numbers would you like to add?  ");
            int field = Convert.ToInt32(Console.ReadLine());

            double[] sumNumber = new double[field];
            double x = 0;

            for (int c = 0; c < field; c++)
            {
                Console.Write("Enter a number:  ");
                sumNumber[c] = Convert.ToDouble(Console.ReadLine());
            }
            foreach (double d in sumNumber)
            {
                x += d;
            }

            double avg = x / field;
            
            Console.WriteLine("Average: {0}", avg);

        }




    }
}
