using System;
using System.IO;

namespace DisplayArchiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo.GetInfo(@"C:\Users\user\Desktop\CourseNet\ArchiveInfoApps\%AppData%\Lesson12Homework.txt");
            Console.ReadKey();
        }
    }
}
