using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {    
            string original, reverse = "";

            Console.Write("Enter a word or words: ");
            original = Console.ReadLine();
            Console.WriteLine("Original: {0}",original);
            
            int length = original.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                if (String.IsNullOrWhiteSpace(original.Substring(i, 1)))
                    continue;
                else
                    reverse = reverse + original.Substring(i, 1);
            }

            string o = original.Replace(" ","");

            Console.WriteLine("Reverse: {0}", reverse);
            Console.WriteLine("Original (no spaces): {0}", o);
            int same = o.CompareTo(reverse);
            if(same==0)
                Console.WriteLine("Yes! It is a palindrome.");
            else
                Console.WriteLine("No, it is not a palindrome.");
            Console.ReadKey();
        }
    }
}
