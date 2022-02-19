using System;

namespace Lab_20_Delegates
{
    class Program
    {
        delegate void MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(ArcLength);
            myDelegate += CircleArea;
            myDelegate += SphereValue;

            myDelegate?.Invoke(5);

        }

        static void ArcLength (double R)
        {
            Console.WriteLine("\nДлина дуги {0}", 2 * System.Math.PI * R);
        }

        static void CircleArea(double R)
        {
            Console.WriteLine("\nПлощадь круга {0}", System.Math.PI * System.Math.Pow(R,2));
        }

        static void SphereValue(double R)
        {
            Console.WriteLine("\nОбъем шара {0}", (4/3)*System.Math.PI * System.Math.Pow(R, 3));
        }

    }
}
