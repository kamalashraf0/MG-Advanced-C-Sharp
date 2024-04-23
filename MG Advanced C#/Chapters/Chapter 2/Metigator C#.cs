using Metigator_Advanced_C_;
using MG_Advanced_C_.Basic_C_;
using MG_Advanced_C_.Chapters.Chapter_2.Basic_C_;

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
                return _amount;
            }
            private set
            {
                //Validation             
                _amount = ProcessValue(value);

            }
        }


        public int Amount2 => _amount;       //same as Amount 

        public int sal { get; set; }         //Default Property


        public void SetAmount(int value) { Amount = value; }
        public int ProcessValue(int value) => value <= 0 ? 0 : value;










        public void Chapter2()
        {

            //var & Dynamic 

            //var is used for compile-time type inference, making code more readable and reducing verbosity,
            //dynamic is used for runtime type resolution,
            //providing flexibility in dealing with types
            //whose structure is not known until runtime or when interacting with dynamic environments.



            var i = 5; var f = 1.56f; var b = true; var s = "Ahmed"; var ar = new int[5];



            dynamic x = 5;
            x = "Ahmed";
            x = true;
            x = new int[5];



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

            int[][] jagged =
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

            var s2 = s1?.ToUpper();          //The ?. operator is used to guard against a null reference exception.

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



            //(Expression Switch)  (=>) Lambda Operator  (_) otherwise

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

            // Boxing and UnBoxing  (Convert from value type to reference type)

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

            //Console.WriteLine(stSegement);


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

            //Delegates  (Method Pointer)

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
            //A partner with Delegates

            var stock = new Stock("Microsoft ");

            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChanged;

            //stock.ChangeStockPriceBy(0.05m);
            //stock.ChangeStockPriceBy(-0.05m);
            //stock.ChangeStockPriceBy(0.00m);



            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            // Operator OverLoading 

            Money money0 = new Money(10);
            Money money = new Money(20);

            Money sum = money0 + money;

            Money sub = sum - money;



            // Console.WriteLine($"Summtion = {sum.Amount} , Substraction = {sub.Amount} , {sum.Amount > sub.Amount}, {money0 < money}   , {sum == sub} , {(++sum).Amount} ");



            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Struct 

            student st = new student();

            // Console.WriteLine(st.x);

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Enums  (default int )






            //Console.WriteLine((int)behaviour.play);

            //var behave = "4";
            //if (Enum.TryParse(behave, out behaviour bh))
            //{
            //    Console.WriteLine(bh);
            //}

            //foreach (var behave1 in Enum.GetValues(typeof(behaviour)))
            //{
            //    Console.WriteLine($"{behave1}  =   {(int)behave1}");
            //}




            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////
            //Generics 

            var numbers = new List<int>();



            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //GenericDelegate 

            IEnumerable<int> nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            GenericDelegate gd = new GenericDelegate();
            //Console.Write($"Numbers less than 6 = ");
            //gd.PrintNums(nums, F => F < 6);
            //Console.Write($"Numbers bigger than 7 = ");
            //gd.PrintNums(nums, F => F > 7);
            //Console.Write($"Even Numbers = ");
            //gd.PrintNums(nums, F => F % 2 == 0);

            //Built in GenericDelegate
            Action<string> print = gd.Print;
            //print("kamal");

            Func<int, int, int> cal = gd.add;
            //Console.WriteLine(cal(5, 6));


            Predicate<int> pred = gd.ISEven;
            //Console.WriteLine(pred(2));

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Exceptions

            //try
            //{ Console.WriteLine(sumtwo()); }
            //catch (Exception ex)
            //{ Console.WriteLine("you r repating yourself"); }
            //finally
            //{ Console.WriteLine(sumtwo(5, 5)); }


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //IEnumerable 





            emp em = new emp();

            //foreach (var item in em)
            //{
            //    Console.WriteLine(item);
            //}




            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Equals

            //emp em = new emp { ID = 1, name = "ahmed" };
            emp em1 = new emp { ID = 1, name = "ahmed" };


            //Console.WriteLine(em1 == em);       //(obj) Reference Comparison
            //Console.WriteLine(em.Equals(em1));    //(obj) Content Comparison if you override (default reference com)



            string da = "helo";
            string ad = "helo";

            //Console.WriteLine(da == ad);     //(string) Content Comparison

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            // XML Documentation for (public members )


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            // Datetime (Extension Method)  => should inside static class and (this) keyword 

            DateTime dt = DateTime.Now;
            DateTimeOffset dts = DateTimeOffset.UtcNow;

            dt = dt.AddDays(3);  // and more methods
            //Console.WriteLine($"{dt.DayOfWeek} \n {dts}");
            //Console.WriteLine(dt.isWeekend());

            int[] ints = { 1, 2, };
            string[] vars = { "ahmed", "kamal" };

            //ints.Print();
            //vars.Print();



            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////
            ///
            //Stream 

            Stream sr = new Stream();

            //Console.WriteLine(sr.getCurrencies());

            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Recursion

            //PrintFilePath(@"F:\Movies & Series", 1);
            var size = PrintsizePath(@"F:\Movies & Series");

            //Console.WriteLine(size);


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //MultiThreading (Single sequential flow of activities)

            // (Thread)no parameter or one argument(object type)  , depending on (Context Switching) via Threads

            var MT = new MultiThreading();

            //var th1 = new Thread(MT.ProcessState1);
            //var th2 = new Thread(MT.ProcessState2);               //OlD Way
            //th1.Start();
            //th2.Start();


            //var cts = new CancellationTokenSource();
            //ThreadPool.QueueUserWorkItem(MT.ProcessState1, cts.Token);

            //ThreadPool.QueueUserWorkItem(MT.ProcessState2, cts.Token);

            //cts.Cancel();   // for Cancel the process thread anytime 


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //


        }

        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        //Recursison 
        public void PrintFilePath(string filePath, int level)
        {
            foreach (var filename in Directory.GetFiles(filePath))
            {
                Console.WriteLine($"{new string('-', level)} {new FileInfo(filename).Name}");

            }

            foreach (var FolderName in Directory.GetDirectories(filePath))
            {
                Console.WriteLine($"{new string('-', level + 1)} {new DirectoryInfo(FolderName).Name}");
                PrintFilePath(FolderName, level + 1);
            }



        }


        public long PrintsizePath(string filePath)
        {
            long size = 0;
            foreach (var filename in Directory.GetFiles(filePath))
            {
                size += new FileInfo(filename).Length;
            }

            foreach (var FolderName in Directory.GetDirectories(filePath))
            {
                size += PrintsizePath(FolderName);
            }
            return size;
        }


        //simple enum
        enum behaviour
        {
            pray = 1,
            Sleep,
            study,
            play
        }


        //flag enum
        [Flags]
        enum DAY
        {

            SUNDAY = 12,
            THRUSDAY = 24

        }






        static int sumtwo(int x = 5, int y = 0)
        {
            return x / y;
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
                Console.WriteLine($"{stock.Name}{stock.Price}");
            }


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

            Console.WriteLine($" Area : {x} * {y} = {res}");
        }

        public void Circle(int x, int y)
        {
            int res = x * y * 10;

            Console.WriteLine($"Cicle : {x} * {y} * 10 = {res}");
        }





    }




}





















