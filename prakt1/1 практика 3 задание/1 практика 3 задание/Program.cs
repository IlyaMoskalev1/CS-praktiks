using System;



namespace _1_практика_3_задание

{

    class task2

    {

        static SByte a = 0;

        static Byte b = 0;

        static Int16 c = 0;

        static Int32 d = 0;

        static Int64 e = 0;

        static string s = "";

        static Exception ex = new Exception();

        static object[] types = { a, b, c, d, e, s, ex };

        static void Main(string[] args)

        {

            foreach (object o in types)

            {

                string type;

                if (o.GetType().IsValueType) type = "Value type";

                else

                    type = "Reference Type";

                Console.WriteLine("{0}:{1}", o.GetType(), type);

            }

        }

    }



}

