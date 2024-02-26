using MG_Advanced_C_;

namespace Metigator_Advanced_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            KudvenOOP kudvenOOP = new KudvenOOP();
            kudvenOOP.Chapter1();

            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//

            /*
             // ClassDef.cs
            
            Console.Write("Enter The radius : ");
            float rad = Convert.ToInt32(Console.ReadLine());
            ChildClassDef CD = new ChildClassDef(rad);
            int Pres = Convert.ToInt32(CD.CircleArea());
            Console.WriteLine(Pres);
            */


            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//
            // PolymorphsimDef.cs

            // The Principle of Polymorphism  and flexibility 
            PolymorphsimDef pd = new childPolymorphsimDef();
            // pd.method();

            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//
            // InterfaceDef.cs

            // we will use here (TypeCast EII)
            Circle c = new Circle();
            //((Shape)c).draw();
            //((ShapeColor)c).draw();

            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//
            //AbstractClass.cs


            AbstractClassDef ab = new Child();
            //ab.Print();


            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//






            Console.ReadKey();

        }
    }
}
