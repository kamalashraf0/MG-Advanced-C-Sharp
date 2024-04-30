namespace MG_LINQ.LINQ
{
    public class ElementOperations
    {
        public static void PElements()
        {
            var emps = Load.LoadEmpoyees();


            #region ElementAt
            //get a specific record 
            #endregion



            var result0 = emps.ElementAt(5 - 1);
            //Console.WriteLine(result0);

            #region ElementorDefault

            //if out of range return default (NULL for obj)

            #endregion


            var result01 = emps.ElementAtOrDefault(100);

            // Console.WriteLine(result01);

            #region First
            // get first record 
            // or first record achieve the expression
            #endregion

            var result = emps.First();
            //Console.WriteLine(result);


            //Handling Exceptions out (null) 
            var fres = emps.FirstOrDefault(e => e.DepartmentID == 7);
            //Console.WriteLine(fres);

            #region Last
            //get last record
            //get last record that achieve the expression
            #endregion



            var result2 = emps.Last(e => e.Email.StartsWith("kamal"));
            //Console.WriteLine(result2);

            var result3 = emps.LastOrDefault(e => e.Email.StartsWith("ahmed1"));
            //Console.WriteLine(result3);

            #region Single

            //get the record only single if duplicate return exception 
            //Handling duplication data
            #endregion

            //var result4 = emps.Single(e => e.FirstName == "kamal16");
            //Console.WriteLine(result4);

            //var result5 = emps.SingleOrDefault(e => e.DepartmentID == 4);
            //Console.WriteLine(result5);


        }
    }
}
