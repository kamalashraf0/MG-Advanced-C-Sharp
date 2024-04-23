using System.Collections;

namespace MG_Advanced_C_.Revision
{
    class Objects
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }
    }


    class ObjectsNavigation : IEnumerable<Objects>
    {
        private readonly List<Objects> objects = new();

        public void Employees(int ID, string Name, decimal Salary)
        {
            objects.Add(new Objects
            {
                ID = ID,
                Name = Name,
                Salary = Salary
            });
        }

        public IEnumerator<Objects> GetEnumerator()
        {
            foreach (var item in objects)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    static class PrintObjectsNavigation
    {

        public static void Print()
        {
            var ON = new ObjectsNavigation();

            for (int i = 0; i < 10; i++)
            {
                ON.Employees(i, $"Employee{i}", Random.Shared.Next(5000, 20000));
            }


            foreach (var item in ON)
            {
                Console.WriteLine($"{item.ID}\t{item.Name}\t{item.Salary}");
            }

        }


        public static void BPrint()
        {

            var o = new Objects();

            List<Objects> list = new();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Objects
                {
                    ID = i,
                    Name = $"Employee{i}",
                    Salary = Random.Shared.Next(5000, 50000)

                });
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.ID}\t{item.Name}\t{item.Salary}");
            }

        }

    }
}
