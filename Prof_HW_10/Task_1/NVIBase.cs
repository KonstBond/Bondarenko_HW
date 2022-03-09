using System;

namespace Task_1
{
    public class NVIBase
    {
        protected DirectoryInfo _dir;

        public void Work(string path)
        {
            PreWork(path);
            DoWork();
            PostWork();
        }

        protected virtual void PreWork(string path)
        {
            //Проверка входных данных
            _dir = new DirectoryInfo(path);
        }
        protected virtual void DoWork()
        {
            foreach (FileInfo file in _dir.GetFiles())
                Console.WriteLine(file.Name);
        }

        protected virtual void PostWork() => _dir = null;
    }
}
