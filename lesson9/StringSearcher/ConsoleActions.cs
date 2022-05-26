using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearcher
{
    class ConsoleActions
    {
        public static bool ConsoleWrite(string str)
        {
            if (str != null)
                Console.WriteLine(str);
            else
            {             
                Console.WriteLine("Поиск окончен");
                return false;
            }    

            Console.WriteLine("\nПродолжить поиск номеров в списке?");
            Console.WriteLine("1 - да, 0 - нет");
            if (int.TryParse(Console.ReadLine(), out int responce))
                switch (responce)
                {
                    case 0: 
                        return false;
                    case 1: 
                        return true;
                }
            Console.WriteLine("Некорректный ввод. Поиск будет продолжен");
            return true;
        }
    }
}
