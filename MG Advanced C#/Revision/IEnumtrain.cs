using System.Collections;

namespace MG_Advanced_C_.Revision
{
    class IEnumtrain : IEnumerable<ILawyer>
    {
        private readonly List<ILawyer> lawyers = new();


        public ILawyer this[int index]
        {
            get => lawyers[index];


            set => lawyers[index] = value;

        }

        public IEnumerator<ILawyer> GetEnumerator()
        {
            foreach (ILawyer l in lawyers)
            {
                yield return l;
            }
        }

        public void lawsSalary(string name, double salary)
        {
            lawyers.Add(new ILawyer { Name = name, Salary = salary });
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    class ILawyer
    {
        public string Name { get; set; }

        public double Salary { get; set; }
    }

}
