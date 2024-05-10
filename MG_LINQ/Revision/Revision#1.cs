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

            var charlist = model.ToList();
            int numberofEmployees = 10;
            var chucnkresult = charlist.Chunk(numberofEmployees).ToList();



            /*
            for (int i = 0; i < chucnkresult.Count; i++)
            {
                Console.WriteLine($"█group#{i + 1}█\n");
                foreach (var item in chucnkresult[i])
                {

                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            */

            //████████████████████████████████████████████████████████████████████████//

            //Any

            //check one element meet the condition
            var AnyResult = model.Any(x => x.E_City == "PortSaid");
            //Console.WriteLine(AnyResult);

            //check all elements meet the condition
            var AllResult = model.All(x => x.E_Salary > 1000);  // is all salaries > 1000 ?
            // Console.WriteLine(AllResult);



            //████████████████████████████████████████████████████████████████████████//

            //it split the records to groups based on the condition 
            //here it will make a group that have all names that starts with "A"
            //and group for the rest of records

            var GroupResult = model.ToLookup(x => x.E_Name.ToLowerInvariant().StartsWith("s")).ToList();
            GroupResult.Reverse();

            /*
            for (int i = 0; i < GroupResult.Count; i++)
            {

                Console.WriteLine("Group : ");
                foreach (var item in GroupResult[i])
                {

                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            */

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

            //████████████████████████████████████████████████████████████████████████//


            var Groupjoinresult = dpmodel.GroupJoin(model, dept => dept.D_ID, emp => emp.D_ID,
        (dept, emp) => new Joins
        {
            Department = dept.D_Name
            ,
            EmployeesName = emp.Select(e => e.E_Name).ToList()
        });



            foreach (var item in Groupjoinresult)
            {
                //Console.WriteLine($"\n({item.Department})\n");

                foreach (var names in item.EmployeesName)
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
                    //Console.WriteLine(names);
                }
            }

            //████████████████████████████████████████████████████████████████████████//

            //Repeat 

            var repeat = model.Where(x => x.E_Name == "Seddik");

            var repeatresult = Enumerable.Repeat(repeat, 10);

            var flatten = repeatresult.SelectMany(x => x);

            foreach (var item in flatten)
            {
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //Range

            var rangeresult = model.Where(x => x.E_Name == "Seddik");
            var range = Enumerable.Range(1, 10);

            var repeatedSequence = range.SelectMany(_ => rangeresult);

            foreach (var item in repeatedSequence)
            {
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //ElementAt 

            // it return the specific record - 1 because it's index starts from zero
            //and default for object (null) if it's null

            var Element = model.ElementAtOrDefault(14 - 1);

            //Console.WriteLine(Element);


            //████████████████████████████████████████████████████████████████████████//

            //First   - Last   - Single

            var first = model.FirstOrDefault();

            //Console.WriteLine(first);

            var last = model.OrderBy(x => x.E_Name).LastOrDefault();

            //Console.WriteLine(last);

            //if it single record it print it back if not it not print Anything 

            var single = model.SingleOrDefault(x => x.E_ID == 1);
            //Console.WriteLine(single);


            //████████████████████████████████████████████████████████████████████████//

            //SequenceEqual

            var seq1 = model.Select(x => x.E_Name).ToList();

            var seq2 = model.Select(x => x.E_Name).ToList();

            var seqequal0 = seq1 == seq2;              // here it compare the reference

            var seqequal = seq1.SequenceEqual(seq2);  // here it compare the content

            //Console.WriteLine(seqequal);

            //████████████████████████████████████████████████████████████████████████//

            //Concat



            var concat = model.Concat(model);

            foreach (var item in concat)
            {
                //Console.WriteLine(item);
            }

            //array concat

            var concatarr = new[] { model, model }.SelectMany(x => x);

            foreach (var item in concatarr)
            {
                Console.WriteLine(item);
            }
        }
    }


}
