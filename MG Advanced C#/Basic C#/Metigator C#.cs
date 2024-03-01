using MG_Advanced_C_.Basic_C_;

namespace MG_Advanced_C_
{
    class Metigator_C_
    {

        //Properties  (Promote Encapsulation) 

        private int _amount;   // You should Introduced a private (backing field) amount to store the actual value of the property.
        public int Amount      //Accessors get (return the argument) , set (assign to value) 
        {
            get
            {
                return this._amount;
            }
            private set
            {
                //Validation             
                this._amount = ProcessValue(value);

            }
        }

        public int sal { get; set; }


        public void SetAmount(int value) { Amount = value; }
        public int ProcessValue(int value) => value <= 0 ? 0 : value;










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

            // Boxing and UnBoxing  (Covert from value type to reference type)

            int ss = 1001;

            object xx = ss;     // (Boxing)

            string ns = null;
            int cc = Convert.ToInt32(ns);   //UnBoxing

            // Console.WriteLine($"{ss} \t {cc}");


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            // Bit Converter  (Binary , Decimal , Hexadecimal, octal)



            //var nums = 10;
            //var bytes = BitConverter.GetBytes(nums);

            //foreach (var bb in bytes)
            //{
            //    var binary = Convert.ToString(bb, 2).PadLeft(8, '0');
            //    Console.WriteLine(binary);
            //}


            //hexa to Asci To char 
            string[] harr = { "4B", "41", "4D", "41", "4c" };

            foreach (var hex in harr)
            {
                int hx = Convert.ToInt32(hex, 16);
                //string hc = char.ConvertFromUtf32(hx);
                char hxc = (char)hx;

                // Console.Write(hc);
                //Console.Write(hxc);


            }

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            // Modeling  (Turn into Class )
            //Indexing  (Every Member have array of values like string have array of characters)


            IP ip = new IP(192, 168, 1, 1);

            var stSegement = ip[0];

            // Console.WriteLine(stSegement);


            string chara = "Kamal";

            char[] charaa = chara.ToCharArray();

            //Console.WriteLine(charaa[0]);

            int[,] matrix = new int[,]
            {
                {5,9,9,8,7,8,10} ,
                {5,9,9,9,7,8,9} ,
                {5,3,10,9,4,5,0} ,
                {5,3,9,9,2,5,0}

            };


            MArray mar = new MArray(matrix);
            //Console.WriteLine(mar[2, 2]);

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Delegates 

            //Employee[] emps = new Employee[]
            //{
            //    new Employee {ID = 1 ,Name ="Kamal" , Gender ="M" , totalSales =60000m},
            //    new Employee {ID = 2 ,Name ="ahmed" , Gender ="M" , totalSales =5000m},
            //    new Employee { ID = 3 , Name = "loamy", Gender = "M", totalSales = 40000m},
            //    new Employee {ID = 4 ,Name ="soad" , Gender ="f" , totalSales =30000m}

            //};

            //Report report = new Report();
            //report.ProcessEmployee(emps, "Sales>=10000", e => e.totalSales > 10000m);   //Lambda Expression (for Defining Delegate)
            //report.ProcessEmployee(emps, "Sales < 10000", e => e.totalSales < 10000m);
            //report.ProcessEmployee(emps, "Sales<60000", e => e.totalSales < 60000m);




            //MultiCast Delegate 




            RecCal react;

            //Built in Delegates
            Action<string> BuiltinDelegate;

            react = Area;
            react += Circle;



            //react(10, 9);


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Events
            //(Events are a language feature that allows a class or object
            //to provide notifications to other parts of the program when certain actions or state changes occur. )
            //A parterre with Delegates

            var stock = new Stock("Microsoft ");

            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChanged;

            //stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.05m);
            //stock.ChangeStockPriceBy(0.00m);

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////






        }



        private void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stock.Name}{stock.Price}");
            }
            else if (stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stock.Name}{stock.Price}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name}{stock.Price}");

        }




        //Single Expression Body Method
        public bool Even(int i) => i % 2 == 0;

        public bool ODD(int i) => !Even(i);

        public string EvenOrODD(int i) => (i % 2 == 0) ? "Even" : "ODD";



        //MultiCast Delegate 
        public delegate void RecCal(int x, int y);


        public void Area(int x, int y)
        {
            int res = x * y;

            Console.WriteLine($"{x} * {y} = {res}");
        }

        public void Circle(int x, int y)
        {
            int res = x * y * 10;

            Console.WriteLine($"{x} * {y} * 10 = {res}");
        }


        //Delegate to Handle the Event 


    }




}





















