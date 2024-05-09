using DataModel;
using DataModel.DBContext;

namespace MG_LINQ.LINQ
{
    public class ConvertingDT
    {
        public static void PCDT()
        {
            #region AsEnumerable()
            //more Readability ,Dynamic  
            #endregion

            var Db = new TrainingContext();

            var emps = Db.EmpModel;

            var result = emps.AsEnumerable();

            foreach (var item in result)
            {
                //Console.WriteLine(item);
            }


            #region AsQueryable()
            //more Readability ,Dynamic  
            #endregion

            var result2 = emps.AsQueryable().Where(x => x.E_Salary > 50000).OrderBy(x => x.E_Salary);

            foreach (var item in result2)
            {
                //Console.WriteLine(item);
            }

            //Console.WriteLine(result2.Expression);   //for just IQueryable 


            #region Cast
            //more Readability ,Dynamic  
            #endregion ??

            var result3 = emps.Where(x => x.GetType() == typeof(EmployeeModel)).Cast<EmployeeModel>();

            foreach (var item in result3)
            {
                //Console.WriteLine(item);
            }


            #region ofType
            //better than cast for handling exceptions  
            #endregion

            var result4 = emps.OfType<EmployeeModel>();

            foreach (var item in result4)
            {
                // Console.WriteLine(item);
            }


            #region ToArray
            //use the records as Array 
            #endregion

            var result5 = emps.ToArray();

            var Count = result5.Length;

            var Slot1 = result5[0];

            //Console.WriteLine(Slot1);

            foreach (var item in result5)
            {
                // Console.WriteLine(item);
            }

            #region ToDictionary
            //Split the records to Keys : Values 
            //using the records as Dictionary
            #endregion


            Dictionary<string, EmployeeModel> result6 = emps.ToDictionary(x => x.E_Name);

            var slot3 = result6["Kamal"];

            //Console.WriteLine(slot3);

            foreach (var item in result6)
            {
                //Console.WriteLine(item);
            }

            #region ToList
            //using the records as List
            #endregion


            var result7 = emps.ToList();

            var Countlist = result7.Count;

            var Slot2 = result7.First();

            //Console.WriteLine(Countlist);

            foreach (var item in result7)
            {
                //Console.WriteLine(item);
            }

            #region ToLookUp
            //better than cast for handling exceptions  
            #endregion ??


            var result8 = emps.ToLookup(x => x.E_Name).First();

            //var slot5 = result8["Ahmed"].First();

            //Console.WriteLine(slot5);

            foreach (var item in result8)
            {
                //Console.WriteLine(item);
            }
        }
    }
}
