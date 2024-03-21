using MG_Advanced_C_.Basic_C_;

namespace MG_Advanced_C_.Revision
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

            // Switch Expression

            string cardname = "king";

            int carnum = cardname switch
            {
                "ACE" => 1,
                "KING" => 13,
                "QUEEN" => 12,
                "JACK" => 13,
                _ => -1
            };

            //Console.WriteLine(carnum);

            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//

            //Matrix Indexing 

            var mat = new int[,]
                {

                    { 9, 0, 0,},
                    { 1, 0, 0,},
                    { 2, 6, 0,},
                    { 3, 0, 0,},
                };

            //Console.WriteLine(mat[2, 1]);

            matrix max = new matrix(mat);

            //Console.WriteLine(max[2, 1]);




            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//

            //delegates 


            //Array Approach
            Employee[] employees = new Employee[100];

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee
                {
                    ID = i,
                    Name = $"Employee {i}",
                    Gender = Random.Shared.Next(2) == 0 ? "Male" : "Female",
                    Salary = Random.Shared.Next(5000, 12000)
                };
            }


            //List Approach
            List<Employee> lemployees = new();

            for (int i = 0; i < 100; i++)
            {
                lemployees.Add(new Employee
                {
                    ID = i,
                    Name = $"Employee {i}",
                    Gender = Random.Shared.Next(2) == 0 ? "Male" : "Female",
                    Salary = Random.Shared.Next(5000, 12000)
                });
            }

            //foreach (var Emp in lemployees)
            //{
            //    Console.WriteLine(Emp);
            //}
            CalculateEvent CE = new CalculateEvent();

            CE.ECalculateSalary += CE_ECalculateSalary;   //Events 

            CE.Calculatesalary(lemployees, s => s.Salary < 8000);


            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//

            //MutliCast Delegate 

            CalDelegate cd;

            cd = ADD;
            cd += Sub;
            //Console.WriteLine(cd(10, 5));

            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
            //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//







        }

        private void CE_ECalculateSalary(Employee e, int salary)
        {
            Console.WriteLine($" Name :{e.Name}  Salary : {e.Salary}");
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








        public delegate int CalDelegate(int num1, int num2);

        public int ADD(int x, int y)
        { return x + y; }

        public int Sub(int x, int y)
        { return x - y; }
    }



}
