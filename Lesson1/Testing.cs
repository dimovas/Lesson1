using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class Testing
    {
        byte b = 255;
        int x = 11;
        uint ux = 1111;
        float y = 5.5f;
        double dy = 5.55;
        string s = "hello!";
        string s1 = "25";
        object obj = new Object();
    

        void WhoIsWho(string name, object any)
            {
                Console.WriteLine("type {0} is {1} , value is {2}",name, any.GetType(), any.ToString());
            }

        public void WhoTest()
        {
            WhoIsWho("x", x);
            WhoIsWho("ux", ux);
            WhoIsWho("y", y);
            WhoIsWho("dy", dy);
            WhoIsWho("s", s);
            WhoIsWho("11+5.55+5.5f", 11 + 5.55 + 5.5f);
            obj = 11 + 5.55 + 5.5f;
            WhoIsWho("obj", obj);
        }

        object Back(object any)
        {
            return (any);
        }

        public void BackTest()
        {
            ux = (uint)Back(ux);
            WhoIsWho("ux", ux);
            s1 = (string)Back(s);
            WhoIsWho("s1", s1);
            x = (int)(uint)Back(ux);
            WhoIsWho("x", x);
            y = (float)(double)Back(11 + 5.55 + 5.5f);
            WhoIsWho("y", y);
                
        }
    }
}


