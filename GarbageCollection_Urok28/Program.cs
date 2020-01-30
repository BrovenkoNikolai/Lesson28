using System;

namespace GarbageCollection_Urok28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            // GC.Collect(); // GC - Сборщик мусора. (0) проверка первого поколения, (1) второго поколения и (2) третьего
            for (int i = 0; i < 10000; i++)
            {
                var obj = (object)i;
                int j = (int)obj;
            }

            using (var c = new MyClass())
            {

            }

            Console.WriteLine(GC.GetTotalMemory(false));

            GC.Collect();

            Console.WriteLine(GC.GetTotalMemory(false));

            Console.ReadLine();
        }
    }
}
