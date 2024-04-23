using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        public static List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

        static void Main(string[] args)
        {
            //Pure and Impure Functions      (Ease to understand , Ease to test)


            foreach (int i in Numbers)
            {
                Console.WriteLine(i);

            }

            PureAndImPure PI = new PureAndImPure();
            //PI.AddInteger(4);
            //PI.AddInteger1(5);
            var newList = PI.AddInteger3(Numbers, 5);

            Console.WriteLine();
            foreach (int i in newList)
            {
                Console.WriteLine(i);
            }


            //--------------------------------------------------------------------------------------//
            //--------------------------------------------------------------------------------------//


            // Functional Programming 



            Console.ReadKey();
        }



    }


}