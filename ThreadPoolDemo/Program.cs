using System;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback delegateMethod = ShowMyText;
            ThreadPool.QueueUserWorkItem(delegateMethod, "test1");
            ThreadPool.QueueUserWorkItem(delegateMethod, "test2");
            ThreadPool.QueueUserWorkItem(delegateMethod, "test3");
            ThreadPool.QueueUserWorkItem(delegateMethod, "test4");
            ThreadPool.QueueUserWorkItem(delegateMethod, "test5");

            Console.ReadLine();
        }

        public static void ShowMyText(Object state)
        {
            Thread.Sleep(100);
            string stateString = (string)state;
            Console.WriteLine($"Tis is my text printer! Object to String is: {stateString}. The thread id is: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
