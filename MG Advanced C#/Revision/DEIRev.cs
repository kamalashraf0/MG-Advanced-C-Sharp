using System.Collections;

namespace MG_Advanced_C_.Revision
{
    class DEIRev
    {



        public delegate bool SalaryChange(Category C);

        public event CatSlaEventHandler ESH;

        public delegate void CatSlaEventHandler(Category C, double Salary);






        public void MSalaryChange(List<Category> c, SalaryChange predicate)
        {
            foreach (var item in c)
            {
                if (predicate(item))
                {
                    //Console.WriteLine($"ID({item.ID}) => {item.Salary})");

                    ESH?.Invoke(item, item.Salary);
                }
            }
        }

    }

    class Category : IEnumerable<Category>
    {

        private List<Category> _categories = new();
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public IEnumerator<Category> GetEnumerator()
        {
            foreach (var item in _categories)
            {
                yield return item;
            }
        }

        public void PrintNameandSalary(int id, string name, double salary)
        {
            _categories.Add(new Category { ID = id, Name = name, Salary = salary });
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
