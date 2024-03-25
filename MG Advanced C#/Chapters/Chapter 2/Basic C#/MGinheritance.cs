namespace MG_Advanced_C_.Basic_C_
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string Name)
        {
            this.Name = Name;
        }
        public virtual void walk()
        {
            Console.WriteLine("Animal");
        }




        public override string ToString()
        {
            return $"Animal :{Name.ToUpper()}  ";
        }


        public override bool Equals(object? obj)
        {
            if (obj == null && obj! is Animal)
                return false;

            var animal = (Animal)obj;

            return this.Name == animal.Name;


            Console.WriteLine("Equals vs OperatorOverloading");
            {
                //if you prioritize adhering to conventions and compatibility with APIs that rely on the Equals method,
                //overriding Equals might be the preferred approach.
                //However,
                //if efficiency and clarity are more important, defining equality operators could be a better choice. 

            }

        }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public static bool operator ==(Animal a1, Animal a2) => a1.Name == a2.Name;
        public static bool operator !=(Animal a1, Animal a2) => a1.Name != a2.Name;




    }


    class frog : Animal
    {

        public frog(string name) : base(name)
        {

        }
        public override void walk()
        {
            base.walk();
        }

        public void Say()
        {
            Console.WriteLine("frog");
        }

    }




}