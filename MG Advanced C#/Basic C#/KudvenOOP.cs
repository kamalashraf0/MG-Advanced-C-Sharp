namespace MG_Advanced_C_
{
    internal class KudvenOOP
    {
        /// <summary>
        /// Explain some C# Syntax      XMl Documentation
        /// </summary>
        public void Chapter1()
        {
            Console.WriteLine("\t");

            //Syntax Place Holder  and String Interpolation $ 




            //int x = 5;
            //int y = 6;
            //int sum = x + y;                                                      
            //Console.WriteLine($" {x} + {y} = {sum}");
            //Console.WriteLine(" {0} + {1} = {2}", x, y, sum);

            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //C# is Case Sensitive




            //int x = 1;
            //int X = 2;
            //int sum = x + X;
            //Console.WriteLine(x + X);

            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            // Escape Sequence 


            //Console.WriteLine("123 \t \n world");

            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //Verbatim Literal   (benefit when using file paths )


            //string path = @"E:\C# Course\C#.NET";
            //Console.WriteLine(path);

            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //Ternary Operator   (Better Than using if statement)



            //int num = 13;
            //string EvenOrOdd = (num % 2 == 0) ? "Even" : "Odd";
            //Console.WriteLine($"The Number {num} is {EvenOrOdd}");

            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //Value Type (non-nullable type) / Ref Type

            //int x = 0;
            //int? X = null;

            //Console.WriteLine($"{x} {X}");

            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //NUll Coalescing Operator

            //( that simplifies the handling of null values.
            //It provides a concise way to choose a default value when an expression results in a null value.)


            int? tickets = null;

            tickets = tickets ?? 0;

            //Console.WriteLine($"available tickets : {tickets}");


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //implicit and Explicit 


            //int x = 5;
            //float y = x + 1.5f;

            //float z = 15.564f;
            //int f = (int)z + 1;     //TypeCast OP (int)  --> (Used when you have a known relationship between types)

            //Console.WriteLine(f);


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //Convert (Handling Null Values)  and  Parse (Exception Handling)




            //int? x = null;
            //string num = Convert.ToString(x);    // output =   
            //int X = Convert.ToInt32(x);          // output = 0

            //string s = "123";
            //char c = 'a';
            //int y = Convert.ToInt32(s);          // output = 123
            //int Y = Convert.ToInt32(c);          // output = 97 (ASCI Code)   


            //Console.WriteLine($"The Num is {num} {X} {y} {Y}");


            //string S = "ab";
            //int  res ;
            //if (int.TryParse(S,  out res))
            //{
            //   Console.WriteLine("Nice");

            //}
            //else
            //{ Console.WriteLine("Boom"); }



            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //Def and out of Arrays



            //int[] arr = new int[2];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the element of Array : ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            // Break (print then out of the body) & Continue (skip or pass)

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i == 4)
            //        continue;
            //    else if (i == 8)
            //        break;

            //    Console.WriteLine(i);
            //}


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //Out Parameter Function


            //int sum = 0;
            //OUTSUM(10, 11, out sum);
            //Console.WriteLine(sum);


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            //Params Function  is a Method Argument (take any number of arguments)

            //paramsfunc(9, 12, 3, 23, 5);

            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////

            // 



        }

        /// <summary>
        /// Out Parameter Function
        /// </summary>
        /// <returns></returns>
        public void OUTSUM(int x, int y, out int sum)
        {
            sum = x + y;

        }

        public void paramsfunc(params int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }


    }
}
