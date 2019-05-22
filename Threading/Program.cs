using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStartDelegate = Counting;
            Thread thread1 = new Thread(threadStartDelegate);
            Thread thread2 = new Thread(threadStartDelegate);

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.ReadLine();
        }

        public static void Counting()
        {
            int counter;
            for (int i = 1; i <= 10; i++)
            {
                counter = i;
                Console.WriteLine($"Current count is:{i}.    Thread is: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(300);
            }
        }
    }
}
