using System;

namespace GarbageCollection_Urok28
{
    class MyClass : IDisposable
    {
        public MyClass() { }

        ~MyClass() { } // диструктор должен быть без аргумента

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
