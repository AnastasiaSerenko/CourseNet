using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static string Calculator()
        {
            Console.WriteLine("Enter expression using space\n" +
                                "to separate the members of expression,\n" +
                                "for example 4 * 5:");
            var exp = Console.ReadLine();
            string[] members = exp.Split(' ');

            if (members.Length == 3)
                if (int.TryParse(members[0], out var mem1) && int.TryParse(members[2], out var mem2))
                    switch (members[1])
                    {
                        case "*":
                            return ($"= {mem1 * mem2}");

                        case "/":
                            if (mem2 != 0)
                                return ($"= {mem1 / mem2}");
                            else
                                return ("Error: divided by zero");

                        case "+":
                            return ($"= {mem1 + mem2}");

                        case "-":
                            return ($"= {mem1 - mem2}");

                        case "%":
                            if (mem2 != 0)
                                return ($"= {mem1 % mem2}");
                            else
                                return ("Error: divided by zero");

                        default:
                            break;
                    }

            return "Incorrect input expression";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculator());
            Console.ReadKey();
        }
    }
}
