using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringSearcher
{
    class StringSearcher
    {
        static Regex _template = 
            new Regex(@"^\+?\d{1}[\s\-]?\d{3}[\s\-]?\d{3}[\s\-]?\d{2}[\s\-]?\d{2}");

        public delegate bool consoleHandle(string arg);
        public static event consoleHandle ConsoleHandle = ConsoleActions.ConsoleWrite;

        public static void Search(List<string> list)
        {
            foreach (string str in list)
            {
                if (_template.IsMatch(str))
                    if (!ConsoleHandle(str))
                        break;
            }
            ConsoleHandle(null);
        }
    }

    
}
