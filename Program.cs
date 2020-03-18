using System;

namespace AboutTheStringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";

            // assign the replaced value to a new string 't'
            string t = s.Replace("e", "i");
            Console.WriteLine(t); // prints hillo

            // overwrite s by assigning the replacement of the current value
            s = s.Replace("e", "i");
            Console.WriteLine(s); // prints hillo
            Console.WriteLine("Hello == hello"); // false
            Console.WriteLine("hello == hello"); // true
            Console.WriteLine("Hello" .Equals("hello")); //false
            Console.WriteLine("hello".Equals("hello")); //true
        }
    }
}
