using System;

namespace Task_1
{
    public class TestClass : IDisposable
    {
        public bool _disposed;
        //Управляемые ресурсы
        public long[] _bigArray;
        //Неуправляемые ресурсы
        FileInfo _file;

        private TestClass()
        {
            _bigArray = new long[10000000];
            _file = new FileInfo(".");
            _disposed = false;
        }

        public TestClass RecursionCreateInstance(TestClass TS)
        {
            return RecursionCreateInstance(TS);
        }

        public static TestClass CreateInstance() => new TestClass();
        public void Dispose() => Dispose(true);
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                // Освобождаем управляемые ресурсы
                // Только в том, случае если вызов был сделан пользователем, и мы уверены в состоянии всех управляемых ресурсов
                _bigArray = null!;
            }
            // освобождаем неуправляемые объекты 
            _file = null!;
            _disposed = true;
            GC.SuppressFinalize(this);
            Console.WriteLine("Object Disposed");
        }
        ~TestClass()
        {
            Dispose(false);
        }
    }
}
