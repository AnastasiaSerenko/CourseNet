using System;

namespace CounterEvents
{
    class Counter
    {
        public int Count { get; private set; }
        public int InterruptNumber { get; }
        readonly EventHandler<int> InterruptHandles;

        public Counter(int InterruptNumber)
        {
            if (InterruptNumber > 0)
                this.InterruptNumber = InterruptNumber;
            else
                this.InterruptNumber = 77;

            InterruptHandles += Handler1.Interrupt;
            InterruptHandles += Handler2.Interrupt;
    }

        public void CounterIncrement()
        {
            for (Count = 0; Count < 100; Count++)
            {
                Console.WriteLine(Count);
                if (Count == InterruptNumber)
                    InterruptHandles(this, InterruptNumber);
            }
        }
    }
}
