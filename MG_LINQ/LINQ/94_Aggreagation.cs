namespace MG_LINQ.LINQ
{
    public class _94_Aggreagation
    {
        public static void PAggregate()
        {


            var arr = new[] { "Kamal", "Ahmed", "Loay", "Zeyad", "Fathi" };

            var result = arr.Aggregate((a, b) => $"{a} , {b}");

            //Console.WriteLine(result);



            var arr2 = new[] { 1, 2, 3, 4, 5, 6 };

            var result2 = arr2.Aggregate(0, (a, b) => a + b);

            //Console.WriteLine(result2);



            //Another Example

            var emps = Load.LoadEmpoyees();

            var empsalary = emps.Select(emp => emp.Salary).ToList();

            var highestsalary = empsalary[0];

            highestsalary = empsalary.Aggregate(highestsalary,
               (highest, next) => highest < next ? next : highest, x => x);

            //Console.WriteLine(highestsalary);


            #region Count
            #endregion


            var empsalarybiggerthan70thounsand = emps.Count(s => s.Salary > 70000);

            //Console.WriteLine(empsalarybiggerthan70thounsand);


            #region Max
            #endregion

            var max0 = emps.Max(s => s.Salary);         //only the max salary
            //Console.WriteLine(max0);

            var max = emps.MaxBy(s => s.Salary);        // the full record of max salary
            //Console.WriteLine(max);


            var min0 = emps.Min(s => s.Salary);        // only the mix salary
            //Console.WriteLine(min0);

            var min = emps.MinBy(s => s.Salary);     // the full record of min salary
            //Console.WriteLine(min);




            #region Sum
            #endregion


            var sum = emps.Sum(s => s.Salary);
            //Console.WriteLine(sum);

            var ave = emps.Average(s => s.Salary);
            //Console.WriteLine(ave);
        }
    }
}
