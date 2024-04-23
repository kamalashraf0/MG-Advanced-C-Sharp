namespace MG_LINQ
{
    static class ProjectionOperation
    {

        public static void Pprojection()
        {
            List<string> list = new() { "I", "Love", "You" };
            List<int> list2 = new() { 1, 2, 3, 4, 5, 6 };


            var print = list.Select(x => x);

            var print2 = list2.Select(x => x * x);


            foreach (var item in print)
            {
                //Console.WriteLine(x);
            }



            #region SelectMany
            // same as select in SQL when filtering the column 
            #endregion

            string[] senetences = {
                "I Love Programming " ,
                ",My Hobby is my dobby",
                " and whatever is never"

            };


            var senlist = senetences.SelectMany(x => x.Split(' '));

            foreach (var item in senlist)
            {
                //Console.WriteLine(item);
            }


            //AnotherExample

            List<Employee> emp = new();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {

                emp.Add(new Employee
                {

                    Id = i,
                    FirstName = Random.Shared.Next(2) == 0 ? $"Ahmed{i}" : $"kamal{i}",
                    LastName = Random.Shared.Next(2) == 0 ? $"Ashraf{i}" : null,
                    Skills = new() { "ASP", ".NET", "JAVA", "C#", "C++", "SQLSERVR" },



                });
            }


            var onlyfirstname = emp.SelectMany(x => x.FirstName.Split(" "));

            var onlyskillQuerySyntax =
                (from e in emp
                 from skill in e.Skills
                 select skill).Distinct();

            foreach (var item in onlyfirstname)
            {
                //Console.WriteLine(item);
            }


            #region ZIP 

            //Merge list elements with another list elements
            #endregion


            List<int> ints = new() { 1, 2, 3 };

            List<string> strs = new() { "kamal", "Ashraf", "Emad" };


            var res = ints.Zip(strs);



            //second example
            var firstnames = emp[..3];
            var secondnames = emp[^3..];

            var zip = firstnames.Zip(secondnames, (first, last) => $"{first.FirstName} with {last.FirstName}");


            var zipQuerySyntax =
                from team in firstnames.Zip(secondnames)
                select $"{team.First.FirstName} {team.Second.LastName}";

            foreach (var item in zipQuerySyntax)
            {
                Console.WriteLine(item);
            }



        }

    }
}
