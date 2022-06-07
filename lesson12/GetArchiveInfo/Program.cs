using System;

namespace GetArchiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Archive(@"C:\Users\user\Desktop\CourseNet\ArchiveInfoApps\CounterEvents.7z")).GetInfo();
        }
    }
}
