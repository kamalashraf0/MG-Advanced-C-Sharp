namespace MG_Advanced_C_.Basic_C_
{
    class Report
    {

        public delegate bool IilegibleSales(Employee e);     // Declaration of Delegate 

        public void ProcessEmployee(Employee[] employees, string title, IilegibleSales isilegibleSales)
        {

            Console.WriteLine(title);
            Console.WriteLine("///////////////////////////////////////////////");

            foreach (Employee e in employees)
            {
                if (isilegibleSales(e))
                {
                    Console.WriteLine($" {e.ID} | {e.Name} | {e.Gender} | {e.totalSales} ");
                }
            }

            Console.WriteLine("\n\n");

        }



    }
}
