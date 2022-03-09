using System;

namespace Task_1
{
    public class Program
    {
        public static void Main()
        {
            NVIBase NVI = new NVIDerived();

            NVI.Work(@".");
        }
    }
}
