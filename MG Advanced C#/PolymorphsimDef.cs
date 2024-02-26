namespace MG_Advanced_C_
{
    class PolymorphsimDef
    {

        public virtual void method()
        {
            Console.WriteLine("base class");
        }



    }

    class childPolymorphsimDef : PolymorphsimDef
    {

        public sealed override void method()
        {
            Console.WriteLine("Child Class");
        }

        public void print() { }

    }

    class derivedPolymorphsimDef : childPolymorphsimDef
    {
        /*
        public override void method()
        {

            //When you mark a method as sealed,
            //it means that you are explicitly preventing further overrides of that method in any derived class.

            Console.WriteLine("derived class");
        }
        */

    }



}
