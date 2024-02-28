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


            // ClassDef.cs

            //Console.Write("Enter The radius : ");
            //float rad = Convert.ToInt32(Console.ReadLine());
            //ChildClassDef CD = new ChildClassDef(rad);
            //int Pres = Convert.ToInt32(CD.CircleArea());
            //Console.WriteLine(Pres);

            //ClassDef PCD = ClassDef.CreateIntance(5);
            //Console.WriteLine(PCD.CircleArea());




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
            //AbstractClassDef.cs


            AbstractClassDef ab = new Child();
            //ab.Print();


            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//

            Metigator_C_ MC = new Metigator_C_();
            MC.Chapter2();









            Console.ReadKey();

        }





    }

    public static class Extensions
    {
        public static void Print<T>(this T[] source)
        {
            if (!source.Any())
            {
                Console.WriteLine("{}");
                return;
            }

            Console.Write("{ ");

            for (var i = 0; i < source.Length; i++)
            {
                Console.Write($"{source[i]}");
                Console.Write(i < source.Length - 1 ? "," : "");
            }
            Console.WriteLine(" }");

        }
    }
}
