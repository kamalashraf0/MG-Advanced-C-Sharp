namespace MG_LINQ.LINQ
{
    static class Quantifiers
    {
        public static void PQany()
        {
            var emps = Load.LoadEmpoyees();


            //Check if exists then return bool (T/F)
            var q = emps.Any(x => x.FirstName.StartsWith("Ahmed1", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(q);

            var q2 = emps.Any(x => x.Salary > 10000);
            //Console.WriteLine(q2);



            //Check if exists then return bool (T/F)
            var a3 = emps.All(x => !string.IsNullOrWhiteSpace(x.Email));
            //Console.WriteLine(a3);



            var c1 = emps.Any(x => x.Email.Contains("yahoo"));
            // Console.WriteLine(c1);





        }
    }
}
