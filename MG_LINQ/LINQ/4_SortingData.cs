namespace MG_LINQ.LINQ
{
    static class SortingData
    {
        public static void PSortingData()
        {

            List<string> fruits = new() { "Banana", "Apple", "Orange", "Mango", "Strawberry" };

            var sorting = fruits.OrderBy(f => f);   // order ASC 
            var sortingDesc = fruits.OrderByDescending(f => f);   // order Desc 
            var sortingthen = fruits.OrderBy(f => f).ThenBy(f => f);   // thenby came after the equality of first order  

            foreach (var f in sorting)
            {
                //Console.WriteLine(f);
            }


            //AnotherExample

            List<Employee> emp = new();



            for (int i = 0; i < 10; i++)
            {
                for (char j = 'z'; j >= 'a'; j--)
                {
                    emp.Add(new Employee
                    {

                        EmployeeNu = $"201{i}-F{j}-134{i}",




                    });
                }
            }

            var sortemp = emp.OrderBy(e => e.EmployeeNu);

            foreach (var f in sortemp)
            {
                //Console.WriteLine(f);
            }



            #region Reverse
            #endregion

            string[] fruity = { "apple", "orange", "mango" };

            var Revres = fruity.Reverse();

            foreach (var item in Revres)
            {
                //Console.WriteLine(item);
            }


        }
    }
}
