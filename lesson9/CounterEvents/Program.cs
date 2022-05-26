using System;

namespace CounterEvents
{
    class Program
    {
        static void Main(string[] args)
        {            
            Counter counter = new(90);
            counter.CounterIncrement();

            Console.ReadKey();
        }
    }
}
