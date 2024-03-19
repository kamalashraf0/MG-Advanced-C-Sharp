namespace MG_Advanced_C_.Basic_C_
{
    class Training
    {

        public void Train1()
        {
            //Ternary Operator 




            //bool x = true;

            //int z = 0;

            ////while (5 > z)
            ////{
            ////    Console.Write("Enter The Num : ");
            ////    int num = int.Parse(Console.ReadLine()); ;

            ////    Console.WriteLine((num % 2 == 0) ? " Even" : " ODD");

            ////    z++;
            ///
            ////}
            //bool isTrue = x ? true : false;

            ////Console.WriteLine(isTrue);

            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//

            //Null Coalescing OP

            string s = null;

            s = s ?? "Undefined";

            //Console.WriteLine(s);


            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//

            //TryParse Convert (For Handling Exceptions)

            //string n = "123";
            //int na;
            //if (int.TryParse(n, out na))
            //{
            //    Console.WriteLine(na);
            //}

            //else { Console.WriteLine("undefined"); }

            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//

            //Method Arguments 

            // Params(5, 8, 4, 8);

            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//

            //




        }

        public void Params(params int[] ara)
        {
            int sum = 0;
            foreach (int i in ara)
            {
                sum += i;


            }

            Console.WriteLine(sum);
        }

    }
}
