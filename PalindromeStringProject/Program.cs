using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeStringProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to check if it is palindrome : ");
            string inputString = Console.ReadLine();
            Console.WriteLine(CheckPalindromeString(inputString));
        }

        static string CheckPalindromeString(string inputString)
        {
            string reversedString = string.Empty;
            for(int i = inputString.Length - 1; i >=0;i--)
            {
                reversedString += inputString[i];
            }
            return reversedString == inputString ? "String is Palindrome" : "String is not Palindrome";
        }
    }
}
