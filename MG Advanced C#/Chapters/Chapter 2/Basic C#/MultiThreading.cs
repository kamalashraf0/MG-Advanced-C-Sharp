namespace MG_Advanced_C_.Chapters.Chapter_2.Basic_C_
{
    class MultiThreading
    {

        // (Thread)no parameter or one argument(object type)  , depending on (Context Switching) via Threads

        private static object _lock = new();
        public void ProcessState1(object? state)
        {
            for (int i = 0; i <= 5000; i++)
            {
                lock (_lock)              //For Accuracy 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public void ProcessState2(object? state)
        {
            lock (_lock)
            {
                for (int i = 5001; i <= 9000; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }
}
