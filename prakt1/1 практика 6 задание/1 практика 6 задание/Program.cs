using System;

namespace _1_практика_6_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 i16 = 1; 
            Int32 i32 = 1; 
            double db = 1;
            i16 = 132;
            i32 = i16;
            db = 116;
            db = i32;
            Console.WriteLine(i16);
            Console.WriteLine(i32);
            Console.WriteLine(db);
        }
    }
}
