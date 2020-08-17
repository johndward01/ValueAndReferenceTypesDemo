using System;
using System.Collections.Generic;
using System.Text;

namespace ValueAndReferenceTypesDemo
{
    static class Methods
    {
        public static void Change(int z)
        {
            z = 500;
        }
        public static void Change(Student s)
        {
            s.id = 3;
            s.name = "Robert";
        }

        public static void ChangeNumber(int num)
        {
            num = 100;
            Console.WriteLine(" " + num);
        }
        public static void ChangeGreeting(string greeting)
        {
            greeting = "Hello class!";            
        }
    }
}
