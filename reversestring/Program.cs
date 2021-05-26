using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me any input, and I'll reverse it and give it back!");
            Console.Write("What do you want me to flip?");
            string input = Console.ReadLine(); //gets string input
            Console.WriteLine(ReverseMe(input)); //calls my function
            
        }
        static string ReverseMe(string str) //says it expects a string input and to return a string
        {
            StringBuilder backwards = new StringBuilder();
            for(int i = str.Length -1; i >= 0;  i-- )
            {
                backwards.Append(str[i]); //appends each letter from the position in the string to the beginning of this string builder, did -1 since positioning starts at 0
            }
            return Convert.ToString(backwards); //converts the string builder to a string
        }
    }
}
