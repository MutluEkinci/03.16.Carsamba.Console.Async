using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Stopwatch sw;
        static async Task Main(string[] args)
        {
            sw = new Stopwatch();

            sw.Start();
            //Islem1();
            //Islem2();
            //Islem1Async();
            //Islem2Async();
            //Islem3Async();

            Task t1 = Islem1Async();
            Task t2 = Islem2Async();
            Task t3 = Islem3Async();

            //t1.Wait();
            //t2.Wait();
            //t3.Wait();

            await Task.WhenAll(t1, t2, t3);
        }

        static async Task Islem1Async()
        {
            Console.WriteLine("Islem1 Basladı");
            await Task.Delay(3000);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Islem1 Bitti");
        }
        static async Task Islem2Async()
        {
            Console.WriteLine("Islem2 Basladı");
            await Task.Delay(5000);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Islem2 Bitti");
        }
        static async Task Islem3Async()
        {
            Console.WriteLine("Islem3 Basladı");
            await Task.Delay(7000);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Islem3 Bitti");
        }

        static void Islem1()
        {
            Console.WriteLine("Islem1 Basladı");
            Task.Delay(3000);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Islem1 Bitti");
        }

        static void Islem2()
        {
            Console.WriteLine("Islem2 Basladı");
            Task.Delay(5000);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("Islem2 Bitti");
        }
    }
}
