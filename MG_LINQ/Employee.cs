namespace MG_LINQ
{
    class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;


        public List<string> Skills { get; set; } = new();


        //static Employee()
        //{
        //    Console.WriteLine("*****************************************************");
        //    Console.WriteLine("ID\tFName\tLName\t\tSkills");
        //    Console.WriteLine("*****************************************************");
        //    Console.WriteLine();



        //}

        public override string ToString()
        {


            return $"{Id}\t{FirstName}\t{LastName}\t\t{Skills[Random.Shared.Next(Skills.Count())]} ";
        }

    }
}
