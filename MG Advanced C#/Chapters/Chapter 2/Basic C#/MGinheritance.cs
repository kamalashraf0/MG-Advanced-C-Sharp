namespace MG_Advanced_C_.Basic_C_
{
    class Animal
    {
        public string Name { get; set; }
        public virtual void walk()
        {
            Console.WriteLine("Animal");
        }




        public override string ToString()
        {
            return $"Animal :{Name}  ";
        }

    }


    class frog : Animal
    {
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