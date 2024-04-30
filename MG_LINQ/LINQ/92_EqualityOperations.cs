namespace MG_LINQ.LINQ
{
    public class _92_EqualityOperations
    {
        public static void PEqual()
        {
            var emps = Load.LoadEmpoyees();

            var e1 = emps.First();
            var e2 = emps.FirstOrDefault();
            var e3 = emps.Last();
            var e4 = emps.FirstOrDefault();

            var lis1 = new List<Employee>(new[] { e1, e2, e3 });
            var lis2 = new List<Employee>(new[] { e1, e2, e4 });

            #region SequenceEqual

            //Check lists if equal to each other
            //every element inside the list should equal to every element inside the other list 

            #endregion

            var equal = lis1.SequenceEqual(lis2);
            Console.WriteLine(equal);



        }
    }
}
