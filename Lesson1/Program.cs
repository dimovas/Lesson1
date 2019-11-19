using System;

namespace Lesson1
{
    class Program
    {
       [STAThread]
        static void Main()
        {
            Testing tm = new Testing();
            Console.WriteLine("Testing.Who Test");
            tm.WhoTest();
            Console.WriteLine("Testing.ToString Test");
            // tm.ToStringTest();
            Console.ReadLine();
        }
    }
}
