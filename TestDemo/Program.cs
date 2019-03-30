using System;
using TestDemo.Solution;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var reverseInt = ReverseInt.Reverse(120);
            //Console.WriteLine(palindrome);
            var palindrome = PalindromeNumber.IsPalindrome(121);
            Console.WriteLine(palindrome);
        }


    }
}
