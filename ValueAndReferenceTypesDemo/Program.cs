using System;
using System.Runtime.InteropServices;

namespace ValueAndReferenceTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //https://en.wikipedia.org/wiki/Type_system#STATIC For more information about Strongly & Statically typed (it's complicated...)

            int defaultValueOfInteger = default;
            double defaultValueOfDouble = default; // Beginning with C# 7.1, you can use the default literal to initialize a variable with the default value of its type
            char defaultValueOfChar = default;
            
            Console.WriteLine(" " + defaultValueOfInteger);
            Console.WriteLine(" " + defaultValueOfDouble);
            Console.WriteLine(" " + defaultValueOfChar);
            Console.WriteLine(" " + "----------------------");
            //-------------------------------------------------------------------------------------------------------------------------
            //When you pass a value-type variable from one method to another, the system creates a separate copy of a variable in another method.
            //If the value is changed in the one method, it will not affect the variable in the other method.

            //  (" " + ) --> All this does is adds a space so the text isn't directly against the left side of the console window


            int num1 = 1;
            Methods.ChangeNumber(num1);
            Console.WriteLine(" " + num1);
            //-------------------------------------------------------------------------------------------------------------------------

            int x = 1;
            int y = x;
            y++;
            Console.WriteLine(" " + x);
            Console.WriteLine(" " + y); // What will be printed out to the console?
            Console.WriteLine(" " + "---------------------------");
            //--------------------------------------------------------------------------------------------------------------------------

            Fraction fraction1 = new Fraction();
            fraction1.numerator = 1;
            fraction1.denominator = 1;

            Fraction fraction2 = fraction1;
            fraction2.numerator = 1111;

            Console.WriteLine(" " + fraction1.numerator); // What will be printed out to the console? (remember: fraction1 is a reference type)
            Console.WriteLine(" " + "---------------------------");
            //---------------------------------------------------------------------------------------------------------------------------

            int z = 5;
            Methods.Change(z);
            Console.WriteLine(" " + z); // What will be printed out to the console? (remember: z is a value type)
            Console.WriteLine(" " + "---------------------------");
            //---------------------------------------------------------------------------------------------------------------------------

            Student s = new Student();
            s.id = 2;
            s.name = "Bobby";
            Methods.Change(s);
            Console.WriteLine(" " + s.id); // What will be printed out to the console? (remember: s is a reference type)
            Console.WriteLine(" " + s.name);    
            
            //BONUS ---------------------------------------------------------------------------------------------------------------------------
            
            string greeting = "Hello";
            Methods.ChangeGreeting(greeting);
            Console.WriteLine(" " + greeting); // What will be printed out to the console? (This one's a bit tricky)
            Console.WriteLine(" " + "---------------------------");
        }
      
    }
}
