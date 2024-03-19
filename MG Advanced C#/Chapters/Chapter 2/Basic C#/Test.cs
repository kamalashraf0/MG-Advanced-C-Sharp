namespace MG_Advanced_C_.Basic_C_
{
    class Test
    {

        public const double TAX = 0.2d;
        public string name { get; set; }

        public int age { get; set; }

        public double salary { get; set; }


        public double netsalary { get; set; }

        Test[] tarr = new Test[2];




        public void SalarySum()
        {


            for (int j = 0; j < tarr.Length; j++)
            {

                tarr[j] = new Test();

                Console.Write($"Employee Number {j + 1}  (Name)     :  ");

                tarr[j].name = Console.ReadLine();

                Console.Write($"Age                           :  ");
                tarr[j].age = int.Parse(Console.ReadLine());
                Console.Write($"Salary (USD)                  :  ");
                tarr[j].salary = int.Parse(Console.ReadLine());

                double total = tarr[j].salary - (tarr[j].salary * TAX);
                tarr[j].netsalary = total;
                // Console.Write($"\nNetSalary (After TAX)        : [{netsalary}] ");

                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();

            }

        }

        public void Print()
        {


            Console.WriteLine("Data: ");
            Console.WriteLine();
            foreach (var item in tarr)
            {


                Console.WriteLine($"Name : {item.name}");
                Console.WriteLine($"Age  : {item.age}");
                Console.WriteLine($"NetSalary : [{item.netsalary}]");
                Console.WriteLine();
            }


        }



    }
}
