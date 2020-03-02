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
            Console.WriteLine("Testing.Back Test");
            tm.BackTest();
            Console.WriteLine("Testing.OLoad Test");
            tm.OLoadTest();
            Console.WriteLine("Testing.ToString Test");
            tm.ToStringTest();
            Console.WriteLine("Testing.FromString Test");
           // tm.FromStringTest();
            Console.WriteLine("Testing.CheckUnchek Test");
            tm.CheckUncheckTest();
            Console.ReadLine();

            System.DateTime dat = Convert.ToDateTime("02.03.2020");
            Console.WriteLine("Date = {0}", dat);
        }
    }
}
