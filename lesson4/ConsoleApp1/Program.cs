using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static string SecondMax() {
            int arraySize;
            string  message = "Enter size of array (more 0):",
                    messageError = "Pls, enter CORRECT value:";

            do {
                Console.WriteLine(message);
                message = messageError;
            } 
            while (!int.TryParse(Console.ReadLine(), out arraySize) 
                    || arraySize <= 0);
            
            
            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++) {
                int temp;
                message = $"Enter number {i}:";
                do
                {
                    Console.WriteLine(message);
                    message = messageError;
                }
                while (!int.TryParse(Console.ReadLine(), out temp));                
                numbers[i] = temp;
            }

            Array.Sort(numbers);

            for (int i = arraySize - 2; i >= 0; i--)            
                if (numbers[i] < numbers[arraySize - 1])
                    return ($"The second maximum value of array is {numbers[i]}");

            return "There is no the second maximum value in array";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SecondMax());
            Console.ReadKey();
        }
    }
}
