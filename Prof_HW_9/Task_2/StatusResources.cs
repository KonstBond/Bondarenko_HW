namespace Task_2
{
    public static class StatusResources
    {
        public static bool _isWorking { get; private set; } = false;
        public static long _needResources { get; private set; }
        private static object _lock = new object();

        public static void CheckResources(long capacity)
        {
            new Thread(StartCheck).Start(capacity);
        }
        private static void StartCheck(object box)
        {
            if (!_isWorking)
            {
                _isWorking = true;
                lock (_lock)
                {
                    while (true)
                    {
                        if (GC.GetTotalMemory(false) > (long)box)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"WARNING!!!\n" +
                                $"Capacity resources has been exceeded");
                            Console.ResetColor();
                            break;
                        }
                    }
                }
                _isWorking = false;
            }
        }
    }
}