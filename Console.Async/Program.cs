using System;
using System.Threading;

namespace Console.Async
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadStart ts1 = new ThreadStart(Yaz);
            ThreadStart ts2 = new ThreadStart(Say);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();
        }
        public static void Yaz()
        {
            for (int i = 0; i < 1000; i++)
            {
                System.Console.WriteLine("AAA:" + i);
            }
        }
        public static void Say()
        {
            for (int i = 0; i < 1000; i++)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
