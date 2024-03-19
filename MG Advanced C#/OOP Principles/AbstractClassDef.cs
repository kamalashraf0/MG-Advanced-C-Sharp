namespace MG_Advanced_C_
{
    /*
     * InComplete Class (Contain only Members Declaration)
     * Can't take an instance from it 
     * Can have Access Modifiers
     
     */

    interface Abstract { }

    public abstract class AbstractClassDef : Abstract                  // Can inherit from interfaces
    {
        public string Name { get; set; }




        public void Print()
        {
            Console.WriteLine("Abstract Print");
        }

        public abstract void Print2();                                  // Abstract Methods (Can't provide Implementation)
                                                                        //Should provide Implementation when you inherit it 
                                                                        //using Override like (virtual methods)


    }


    public class Child() : AbstractClassDef
    {

        public override void Print2()
        {
            Console.WriteLine("Child Print");
        }


        public void Radius()
        {
            Console.WriteLine("Circle Radius");
        }
    }

    public class Child2() : AbstractClassDef
    {

        public override void Print2()
        {
            Console.WriteLine("Child2 Print");
        }
    }
}
