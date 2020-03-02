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

        void OLoad (float par)
        {
            Console.WriteLine("Float value {0}", par);
        }
        void OLoad(long par)
        {
            Console.WriteLine("Long value {0}", par);
        }
        void OLoad(ulong par)
        {
            Console.WriteLine("Ulong value {0}", par);
        }
        void OLoad(double par)
        {
            Console.WriteLine("Double value {0}", par);
        }
        void OLoad(long par1, long par2)
        {
            Console.WriteLine("Long par1 {0}, Long par2 {1}", par1, par2);
        }
        void OLoad(double par1, double par2)
        {
            Console.WriteLine("Double par1 {0}, Double par2 {1}", par1, par2);
        }
        void OLoad(int par1, float par2)
        {
            Console.WriteLine("Int par1 {0}, Float par2 {1}", par1, par2);
        }

        public void OLoadTest()
        {
            OLoad(x);
            OLoad(ux);
            OLoad(y);
            OLoad(dy);
            // OLoad(x,ux); //conflict (int, float) & (long, long)
            OLoad(x,(float)ux);
            OLoad(y, dy);
            OLoad(x, dy);
        }
        
        public void ToStringTest()
        {
            s = "Владимир Петров ";
            s1 = "Возраст: ";
            ux = 27;
            s = s + s1 + ux.ToString();
            s1 = " Зарплата: ";
            dy = 2700.5;
            s = s + s1 + dy;
            WhoIsWho("s", s);
        }

        public void FromStringTest()
        {
            s = "Введите возраст ";
            Console.WriteLine(s);
            s1 = Console.ReadLine();
            ux = Convert.ToUInt32(s1);
            WhoIsWho("Возраст: ", ux);
            s = "Введите зарплату ";
            Console.WriteLine(s);
            s1 = Console.ReadLine();
            dy = Convert.ToDouble(s1);
            WhoIsWho("Зарплата: ", dy);
        }

        public void CheckUncheckTest()
        {
            x = -25 ^ 2;
            WhoIsWho("x", x);
            b = 255;
            WhoIsWho("b", b);

            checked
            {
                try
                {
                    b += 1;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Переполнение при вычислении b");
                    Console.WriteLine(e);
                }
                try
                {
                    b = (byte)x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Переполнение при преобразовании к  byte");
                    Console.WriteLine(e);
                }
                unchecked
                {
                    try
                    {
                        b += 1;
                        WhoIsWho("b", b);
                        b = (byte)x;
                        WhoIsWho("b", b);
                        ux = (uint)x;
                        WhoIsWho("ux", ux);
                        Console.WriteLine("Исключений нет, но результаты не верны!.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Этот текст не должен появляться");
                        Console.WriteLine(e);
                    }
                    try
                    {
                        b = Convert.ToByte(x);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Переполнение при преобразовании к  byte");
                        Console.WriteLine(e);
                    }
                    try
                    {
                        ux = Convert.ToUInt32(x);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Потеря знака при преобразовании к Uint!");
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}


