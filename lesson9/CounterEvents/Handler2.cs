using System;

namespace CounterEvents
{
    class Handler2
    {
        public static void Interrupt(object obj, int InterruptNumber)
        {
            Console.WriteLine($"Уже {InterruptNumber}, давно пора было начать!");
        }
    }
}
