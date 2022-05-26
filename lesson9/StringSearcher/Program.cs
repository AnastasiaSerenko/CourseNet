using System;
using System.Collections.Generic;

namespace StringSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phoneNumbers = new List<string>
            {
                "+79558072782",
                "8 955 807 27 82",
                "+7-955-807-27-82",
                "+7-955-807-2782",
                "++79558072782",
                "+7--955-807-27-82",
                "8  955 807 27 82",
                "955 807 27 82",
            };

            StringSearcher.Search(phoneNumbers);
            Console.ReadKey();
        }
    }
}
