namespace MG_Advanced_C_.Revision
{
    class Worker
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $" {Name} | ={Salary}";
        }
    }

    class DE
    {

        public delegate bool CalculateSalaryDelegate(Worker w);

        public event DEEventHandler CalSalaryEvent;

        public delegate void DEEventHandler(Worker w);

        public void CalculateSalary(List<Worker> workers, string title, CalculateSalaryDelegate predicate)
        {

            Console.WriteLine(title);
            Console.WriteLine("-----------------");
            foreach (Worker w2 in workers)
            {
                if (predicate(w2))   // is true 
                {
                    CalSalaryEvent?.Invoke(w2);   // is not null
                }
            }

        }

    }


}
