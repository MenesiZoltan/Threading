using System;
using System.Threading;

namespace SingleInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex myVar = null;
            const string mutexName = "RUNMEONLYONCE";
            int counter = 0;

            while (true)
            {
                try
                {
                    myVar = Mutex.OpenExisting(mutexName);
                    myVar.Close();
                    Console.WriteLine(counter);
                    Console.ReadLine();
                    counter++;
                    Environment.Exit(1);
                }
                catch (WaitHandleCannotBeOpenedException e)
                {
                    Console.WriteLine($"Error caught, {mutexName} can not be closed. Iteration {counter}. \n{e}");
                    Console.ReadLine();
                    counter++;
                }
            }
        }
    }
}
