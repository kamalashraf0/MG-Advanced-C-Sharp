namespace MG_LINQ.LINQ
{
    public static class Grouping
    {

        //Uses deferred execution
        //each iterate => group again !!!

        //(for single process)
        public static void PGroubBY()
        {
            var emps = Load.LoadEmpoyees();

            //var res = emps.GroupBy(x => x.Department).ToList();

            //var QuerySyntax = (from emp in emps
            //                   where emp.Department.StartsWith("T")
            //                   group emp by emp.Department).ToList();

            //for (int i = 0; i < QuerySyntax.Count; i++)
            //{


            //    foreach (var group in QuerySyntax[i])
            //    {


            //        //Console.WriteLine(group);
            //    }
            //}
        }

        #region ToLookUp
        #endregion



        //Uses Immediate execution
        //buffer the result in memory
        //for (Multiple process)
        public static void PToLookUp()
        {
            var emps = Load.LoadEmpoyees();

            var res = emps.ToLookup(x => x.Department).ToList();

            //var QuerySyntax = (from emp in emps
            //                   where emp.Department.StartsWith("T")
            //                   group emp by emp.Department).ToList();

            //for (int i = 0; i < QuerySyntax.Count; i++)
            //{


            //    foreach (var group in QuerySyntax[i])
            //    {


            //        //Console.WriteLine(group);   
            //    }
            //}
        }
    }
}
