namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Employee> Employee = new List<Employee>();

            for (int i = 0; i < 100; i++)
            {
                Employee.Add(new Employee
                {
                    Id = i,
                    Name = $"Employee{i}",



                });
            }



            Indexing I = new Indexing();



            I.ProcessID += I_ProcessID;

            I.ProcessSalary(Employee, e => e.Id > 50);


            Console.ReadKey();

        }

        private static void I_ProcessID(Employee e, int ID)
        {
            Console.WriteLine($"ID = {e.Id} Name = {e.Name}");
        }
    }
}
