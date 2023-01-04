using System;

namespace PassByRefference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"zmienna przed uzyciem metody: {x}");
            Multiply( x);
            Console.WriteLine($"zmienna po uzyciu metody: {x}");
          
            int y = 10;
            Console.WriteLine($"zmienna przed uzyciem metody: {y}");
            
            Multiply1(ref y);
            Console.WriteLine($"zmienna po uzyciu metody: {y}");
            

            Console.WriteLine("enter to exit");
            Console.ReadLine();
        }
        public static void Multiply( int x)//nic nie zwraca
        {
            x*= x;
           
        }

        public static void Multiply1(ref int y)
        {
            y *= y;

        }
    }
}