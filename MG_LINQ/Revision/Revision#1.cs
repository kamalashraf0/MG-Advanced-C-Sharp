using DataModel.DBContext;


namespace MG_LINQ.Revision
{
    public class Revision_1
    {
        public static void Print()
        {
            //
            //var db = new TrainingContext();
            //var model = db.EmpModel;
            //var db2 = new DepartmentContext();
            //var dpmodel = db2.DeptModel;

            var db = new ApplicationDbContext();
            var model = db.EmpModel;
            var dpmodel = db.DeptModel;




            //████████████████████████████████████████████████████████████████████████//

            //Where  => (is need for expression or just a declaration to x)


            var WhereResult = model.Where(x => x.E_City.StartsWith("C"));

            var WhereQuerySyntax =
                (from x in model
                 where x.E_Age >= 23 && x.E_Age <= 30
                 select x).OrderBy(x => x.E_Age)
                 .ThenBy(x => x.E_Salary).ThenBy(x => x.MedicalInsurance.StartsWith("has"));

            try
            {
                foreach (var item in WhereQuerySyntax)
                {

                    //Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            //████████████████████████████████████████████████████████████████████████//

            //Select   (it return bool for expression)

            var SelectResult = model.Select(x => x.E_City.StartsWith("C"));

            foreach (var item in SelectResult)
            {
                // Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //SelectMany

            //( is used to flatten a sequence of sequences into a single sequence)
            //It projects each element of the input sequence to an IEnumerable<T>
            //and flattens the resulting sequences into one sequence. 

            var list = model.ToList();

            var ManyResult = list.SelectMany(x => x.E_Name.Split(" "));

            foreach (var item in ManyResult)
            {
                // Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //Zip (Assigning list to another list)
            //Zipping need a List of Elements to make an operation

            var zip1 = model.OrderByDescending(x => x.E_Name).Select(x => x.E_Name).Take(3).ToList();
            var zip2 = model.Select(x => x.MedicalInsurance).Take(3).ToList();


            var ZipResult = zip1.Zip(zip2);

            var ziplist = model.ToList();

            var ZipResult2 = ziplist.Zip(ziplist, (first, second) => $"{first.E_Name} {second.E_Salary}");

            foreach (var item in ZipResult2)
            {
                //Console.WriteLine(item);
            }


            //████████████████████████████████████████████████████████████████████████//

            //Reverse

            var ReverseModel = model.Select(x => x).AsEnumerable().Reverse();

            foreach (var item in ReverseModel)
            {
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            // Skip  - Take - Chunk

            var SkipResult = model.AsQueryable().Skip(5);


            var SkipResult2 = model.AsEnumerable().SkipLast(5);
            //var SkipResult3 = model.AsQueryable().SkipLast(5);    //(skiplast) doesn't support LINQ to SQL


            var SkipwhileResult = model.AsEnumerable().SkipWhile(x => x.E_ID != 10);


            foreach (var item in SkipwhileResult)
            {
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//


            var TakeResult = model.AsQueryable().Take(5);


            var TakeResult2 = model.AsEnumerable().TakeLast(5);

            var TakewhileResult = model.AsEnumerable().TakeWhile(x => x.E_ID != 10);


            foreach (var item in TakewhileResult)
            {
                //Console.WriteLine(item);
            }
            //████████████████████████████████████████████████████████████████████████//

            //Chunk split into groups

            int numberofEmployees = 10;
            var chucnkresult = model.AsEnumerable().Chunk(numberofEmployees).ToList();


            /* for (int i = 0; i < chucnkresult.Count; i++)
             {
                 Console.WriteLine($"█group#{i + 1}█\n");
                 foreach (var item in chucnkresult[i])
                 {

                     Console.WriteLine(item);
                 }
                 Console.WriteLine();
             }*/


            //████████████████████████████████████████████████████████████████████████//

            //Any

            //check one element meet the condition
            var AnyResult = model.Any(x => x.E_City == "PortSaid");
            //Console.WriteLine(AnyResult);

            //check all elements meet the condition
            var AllResult = model.All(x => x.E_Salary > 1000);  // is all salaries > 1000 ?
            // Console.WriteLine(AllResult);



            //████████████████████████████████████████████████████████████████████████//

            var GroupResult = model.ToLookup(x => x.E_Name.StartsWith("A")).ToList();
            GroupResult.Reverse();


            for (int i = 0; i < GroupResult.Count; i++)
            {


                foreach (var item in GroupResult[i])
                {
                    //
                    //Console.WriteLine(item);
                }
            }


            //████████████████████████████████████████████████████████████████████████//

            //joins

            var joinresult = dpmodel.Join(model, dept => dept.D_ID, emp => emp.D_ID,
        (dept, emp) => new EmployeeDept
        {
            Department = dept.D_Name
            ,
            Employees = emp.E_Name
        });

            foreach (var item in joinresult)
            {
                //Console.WriteLine($"{item.Employees}  ({item.Department})");
            }

            var Groupjoinresult = dpmodel.GroupJoin(model, dept => dept.D_ID, emp => emp.D_ID,
        (dept, emp) => new Joins
        {
            Department = dept.D_Name
            ,
            Employees = emp.Select(e => e).ToList()
        });



            foreach (var item in Groupjoinresult)
            {
                //Console.WriteLine($"\n({item.Department})\n");

                foreach (var names in item.Employees)
                {
                    //Console.WriteLine(names);
                }
            }


            var joinsResultQuery = from d in dpmodel
                                   join e in model on d.D_ID equals e.D_ID into empgroup
                                   select new { DepartmentName = d.D_Name, Employees = empgroup };

            foreach (var item in joinsResultQuery)
            {
                //Console.WriteLine($"\n{item.DepartmentName}\n");
                foreach (var names in item.Employees)
                {
                    //Console.WriteLine(names.E_Name);
                }
            }

            //████████████████████████████████████████████████████████████████████████//



        }
    }


}
