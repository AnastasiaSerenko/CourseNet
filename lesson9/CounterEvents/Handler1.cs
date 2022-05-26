using System;

namespace CounterEvents
{
    class Handler1
    {
        public static void Interrupt(object obj, int InterruptNumber) 
        {
            Console.WriteLine($"Пора действовать, ведь уже {InterruptNumber}");
        }
    }
}
