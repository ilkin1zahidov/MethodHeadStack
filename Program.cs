using System;

namespace MethodHeadStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(name1("Ilkin"));
        }

        static string name1(string name)
        {
            string result = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                result += name[i];
            }
            return result;
        }
    }
    
        
}
