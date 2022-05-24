using System;

namespace ConsoleAppAkulova { 

    class Program { 
        static void Main (string[] args){       
            Console.WriteLine("Let's multiply numbers!\nEnter the first number:");
            var strNum1 = Console.ReadLine();    
            
            Console.WriteLine("Enter the second number:");
            var strNum2 = Console.ReadLine();    

            if (int.TryParse(strNum1, out var intNum1) && int.TryParse(strNum2, out var intNum2))
                Console.WriteLine($"\n{intNum1} * {intNum2} = {intNum1 * intNum2}");
            else
                Console.WriteLine("Error: incorrect input data");
            
            Console.ReadKey();
        }
    }
}
