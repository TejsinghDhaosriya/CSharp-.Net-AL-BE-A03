using System;
using static System.Console;
namespace SingletonDesignPatternConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = Counter.GetInstance;
            WriteLine(counter.Count());

            counter.Increment();
            counter.Increment();
            counter.Increment();
            WriteLine(counter.Count());

            counter.Decrement();
            WriteLine(counter.Count());


            //Singleton Check

            Counter counter2 = Counter.GetInstance;
            WriteLine(counter2.Count());
            if (counter == counter2)
                WriteLine("Both are Same");


            Read();

        }
    }
}
