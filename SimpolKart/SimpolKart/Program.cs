using System;

namespace SimpolKart
{
    class Program
    {
        static void Main(string[] args)
        {
            string k1, k2, k3;
            Console.WriteLine("Доступные картинки нарисованиые символами:");
            Console.WriteLine("SMAL");
            Console.WriteLine("Small");
            Console.WriteLine("Kroll");
            Console.WriteLine("Mahh");
            k1 = Convert.ToString(Console.ReadLine());
            k2 = Convert.ToString(Console.ReadLine());
            if (k1 == "Small")
            {
                Console.WriteLine("(>'•')");
            }
            if (k1 == "SMAL")
            {
                Console.WriteLine("(・_＋)");
            }
            if (k1 == "Kroll")
            {
                Console.WriteLine ("o,,,o   /),/)");
                Console.WriteLine("( ' : ' )( ' ; ' )");
                Console.WriteLine("(,,)-(,,)(,,)-(,,)");
               
            }
            if (k1 == "Mahh")
            {
                Console.WriteLine("     ____()()");
                Console.WriteLine("   /           @@");
                Console.WriteLine("~~~~~m__m._>o");
                
            }
            Console.ReadKey();
        }
    }
}
