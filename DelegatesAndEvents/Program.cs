

class program
{
    public static async Task Main(string[] args)
    {
        var Employees = new List<Employee>();


        for (int i = 0; i < 100; i++)
        {
            Employees.Add(new Employee
            {
                ID = i,
                Name = "Employee",
                Salary = Random.Shared.Next(10000, 50000),

            }); ;
        }


        Employee employee = new Employee();

        employee.SalaryChanged += Employee_SalaryChanged;
        employee.PrintSalary(Employees, "Salaries < 20000", e => e.Salary < 20000);
        await Console.Out.WriteLineAsync();
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||");
        await Console.Out.WriteLineAsync();
        employee.PrintSalary(Employees, "Salaries > 30000", e => e.Salary > 30000);





        //foreach (Employee emp in Employees)
        //{
        //    await Console.Out.WriteLineAsync($"{emp.Name} {emp.ID} : {emp.Salary}");
        //}

        Console.ReadKey();
    }

    private static void Employee_SalaryChanged(Employee e, double salary)
    {
        Console.WriteLine($"{e.Name} {e.ID} : ");
    }

    class Employee
    {

        public event SalaryEventHandler SalaryChanged;

        public delegate void SalaryEventHandler(Employee e, double salary);

        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void PrintSalary(List<Employee> list, string title, Predicate<Employee> predicate)
        {
            Console.WriteLine(title);
            Console.WriteLine("----------------------------");
            foreach (Employee e in list)
            {
                if (predicate(e))    //Check if delegate is true 
                {

                    SalaryChanged?.Invoke(e, e.Salary);

                }

            }

        }

    }

}