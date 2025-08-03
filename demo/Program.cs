using System.Numerics;


using demo.OverLoading;
namespace demo
{
    internal class Program
    {

        #region Two numbers method
        //static int SumNumbers(int x, int y)
        //{
        //    return x + y;
        //}

        //static double SumNumbers(double x, double y)
        //{
        //    return x + y;
        //}

        //static int SumNumbers(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //////هنا الكلام ده invalid 
        ////static double SumTowNumbers(int a, int b)
        ////{
        ////    return (double)a + (double)b;
        ////}

        //static double SumNumbers(int x, double y)
        //{
        //    return x + y;
        //}
        ////static double SumNumbers(double x, int y)
        ////{
        ////    return x + y;
        ////}
        ////في ال 2 methods دول ال combiler مش هيعمل error و لكن مش اصح حلجه علشان انا ممكن اعمل الكلام ده بال method by name 


        #endregion
        static void Main(string[] args)
        {
            #region Video-3
            ////Method Overloading
            //int a = 10, b = 20, c = 30;
            //int result = SumNumbers(a, b);
            //result = SumNumbers(a, b, c);
            //SumNumbers(10.10, 20.20);
            //SumNumbers(y: 1.2, x: 2.2);//ده كده method by name
            //Console.WriteLine(result);
            #endregion

            #region Video-4
            //Operators Overloading

            Complexx C1 = new Complexx();
            C1.Real = 10;
            C1.Img = 5;
            Console.WriteLine(C1);

            Complexx C2 = new Complexx() { Real=6 , Img=2};
            Console.WriteLine(C2);

            Complexx C3 = new Complexx();
            C3 = C1 + C2;//Invalid before Operator overloading
            C3 += C1;//valid because it a (C3=C3+C1) 
            C3 = C1 - C2;//VALID AFTER OPERATOR OVERLOADING
            Console.WriteLine($"C3={C3}");

            #endregion
        }
    }
}
