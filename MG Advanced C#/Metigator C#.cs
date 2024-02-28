namespace MG_Advanced_C_
{
    class Metigator_C_
    {
        public void Chapter2()
        {

            //var & Dynamic 

            var i = 5; var f = 1.56f; var b = true; var s = "Ahmed"; var ar = new int[5];



            dynamic x = 5;
            x = "Ahmed";
            x = true;





            // Multi Dimensional Array [,]

            int[,] a =
             {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
                { 7, 8 }
            };


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Jagged Array (Array inside Array)

            int[][] jagged = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3,4 },
                new int [] { 5 },


            };

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Indices's and Ranges 

            var arr = new string[] { "Soha", "Hossam", "Noha", "Loay", "Medhat", "Hazem", "Kamal" };

            var slice = 3..5;
            var slices = arr[slice];

            //slices.Print();

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Primary Expression 

            var PI = Math.PI;

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            // Null Conditioning

            string s1 = null;

            var s2 = s1?.ToUpper();

            //Console.WriteLine(s2);

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            // Block Statements


            //Console.WriteLine("Hello World");
            //{
            //    Console.WriteLine("Hello, ");
            //    Console.WriteLine("Kimo");
            //}

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////


            //switch 
            //(Predict Switch)



            //bool bi = true;
            //switch (bi)
            //{
            //    case bool v when v == true:
            //        Console.WriteLine("yes");
            //        break;
            //}



            //(Expression Switch)  => (Lambda Operator)   _ (otherwise)

            var carNum = 13;

            string cardName = carNum switch
            {
                1 => "ACE",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => carNum.ToString()

            };

            //Console.WriteLine(cardName);

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Fib


            //for (int ii = 0, prev = 0, current = 1; ii < 10; ii++)
            //{
            //    Console.Write(prev + " ");
            //    int fib = prev + current;
            //    prev = current;
            //    current = fib;
            //}

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //



        }

        //String Expression 
        public string Even(int i) => (i % 2 == 0) ? "Even" : "ODD";


    }
}
