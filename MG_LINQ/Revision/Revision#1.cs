using DataModel;
using DataModel.DBContext;
using System.Linq.Expressions;


namespace MG_LINQ.Revision
{
    static public class Revision_1
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

            var joinresult2 = dpmodel.Join(model, dept => dept.D_ID, emp => emp.D_ID,
            (dept, emp) => new { dept.D_Name, emp.E_Name });

            foreach (var item in joinresult2)
            {
                Console.WriteLine($"{item.E_Name}  ({item.D_Name})");
            }

            //████████████████████████████████████████████████████████████████████████//

            //GroupJoins

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


            var Groupjoinresult2 = dpmodel.GroupJoin(model, dept => dept.D_ID, emp => emp.D_ID,
    (dept, emp) => new { dept.D_Name, empnames = emp.Select(x => x.E_Name) });



            foreach (var item in Groupjoinresult2)
            {
                //Console.WriteLine($"\n({item.D_Name})\n");

                foreach (var names in item.empnames)
                {
                    // Console.WriteLine(names);
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
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //Aggregation

            //Params(1, 5, 3, 9, 18, 7);
            //SParams("kamal", "Ahmed", "Loay");


            var MX = model.Max(x => x.E_Salary);
            //Console.WriteLine(MX);
            var MXby = model.AsEnumerable().MaxBy(x => x.E_ID);
            //Console.WriteLine(MXby);

            //████████████████████████████████████████████████████████████████████████//

            // UNION - Intersect - Except 


            var strlist = new[] { "Kamal", "Omar", "Seddik", "Zain", "Salah" };


            var modnamelist = model.Select(x => x.E_Name).ToList();

            var union = modnamelist.Union(strlist);

            var aggregate = union.Aggregate((a, b) => $"{a} - {b}");

            foreach (var item in aggregate)
            {
                //Console.Write(item);
            }

            var unionby = model.AsEnumerable().UnionBy(model, s => s);

            foreach (var item in unionby)
            {
                //Console.WriteLine(item);
            }



            var intersect = modnamelist.Intersect(strlist);

            foreach (var item in intersect)
            {
                //Console.WriteLine(item);
            }

            var interesectby = model.AsEnumerable().IntersectBy(model, s => s);

            foreach (var item in unionby)
            {
                //Console.WriteLine(item);
            }

            var except = strlist.Except(modnamelist);

            foreach (var item in except)
            {
                //Console.WriteLine(item);
            }


            var exceptby = model.AsEnumerable().ExceptBy(model, s => s);

            foreach (var item in unionby)
            {
                //Console.WriteLine(item);
            }
            //████████████████████████████████████████████████████████████████████████//

            // Expression Tree

            /*           num => num % 2 == 0        */

            Expression<Func<int, bool>> isEven = num => num % 2 == 0;

            ParameterExpression Num = isEven.Parameters[0];
            BinaryExpression MainBody = (BinaryExpression)isEven.Body;
            BinaryExpression leftbody = (BinaryExpression)MainBody.Left;
            ParameterExpression leftNum = (ParameterExpression)leftbody.Left;
            ConstantExpression Constant1 = (ConstantExpression)leftbody.Right;
            ConstantExpression Constant2 = (ConstantExpression)MainBody.Right;

            //Console.WriteLine($"Expression Tree : {Num.Name} => " +
            //  $"{leftNum.Name} {leftbody.NodeType} {Constant1.Value} {MainBody.NodeType} {Constant2.Value} ");


            ParameterExpression Lnum = Expression.Parameter(typeof(int));
            ConstantExpression L2 = Expression.Constant(2);
            BinaryExpression LMod = Expression.Modulo(Lnum, L2);
            ConstantExpression L0 = Expression.Constant(0);
            BinaryExpression Lequal = Expression.Equal(LMod, L0);

            Expression<Func<int, bool>> IsLambdaEven =
                Expression.Lambda<Func<int, bool>>(Lequal, new ParameterExpression[] { Lnum });


            Func<int, bool> ItIsEven = IsLambdaEven.Compile();

            //Console.WriteLine(ItIsEven(9));

            //████████████████████████████████████████████████████████████████████████//

            //Method Chaining (Functional Programming)

            var FluentAPI = model.OrderBy(x => x.E_Name).Skip(10).Take(2).
                                  OrderByDescending(x => x.E_Salary).ThenByDescending(x => x.E_Age);

            foreach (var item in FluentAPI)
            {
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //Defferd Execution

            var delist = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var deresult = delist.Where(x => x > 2);    // here we save the query functionality not the result 



            foreach (var item in deresult)
            {
                // Console.WriteLine(item);
            }
            Console.WriteLine(" --------------------------------- ");

            delist.AddRange(new[] { 9, 12, 13 });

            //Console.WriteLine("Deffered Execution : ");

            foreach (var item in deresult)
            {
                // Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //Imediate Execution

            deresult.ToList();    // here we save the result into list


            IQueryable<EmployeeModel> Imresult = model.Select(x => x);

            foreach (var item in Imresult)
            {
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //ofType

            var Isresult = model.Select(x => x is EmployeeModel);  //return bool if records from this class

            foreach (var item in Isresult)
            {
                // Console.WriteLine(item);
            }

            //(oftype)  tells you that i want to print the records that belong to this class (EmployeeModel)
            var oftyperesult = model.AsEnumerable().OfType<EmployeeModel>().Select(x => x);

            foreach (var item in oftyperesult)
            {
                //Console.WriteLine(item);
            }
            //████████████████████████████████████████████████████████████████████████//

            //Extension method (Partioning) Paginate

            var pageresult = model.RPaginate(1, 5);


            foreach (var item in pageresult)
            {
                // Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//

            //Distinct

            var disresult = model.AsEnumerable().DistinctBy(x => x.D_ID);

            foreach (var item in disresult)
            {
                //Console.WriteLine(item);
            }

            //████████████████████████████████████████████████████████████████████████//


        }


        public static IEnumerable<T> RPaginate<T>(this IEnumerable<T> source, int page = 1, int pagesize = 10)
        {
            if (source == null) throw new ArgumentNullException();

            if (pagesize < 0) pagesize = 10;

            if (page < 0) page = 1;

            var Pages = source.Skip((page - 1) * pagesize).Take(pagesize).ToList();

            return Pages;
        }

        public static void Params(params int[] arr)
        {
            var aggregate = arr.Aggregate(0, (a, b) => a + b);

            Console.WriteLine(aggregate);
        }

        public static void SParams(IEnumerable<string> union, params string[] arr)
        {
            var aggregate = arr.Aggregate((a, b) => $"{a} , {b}");

            Console.WriteLine(aggregate);
        }
    }


}
