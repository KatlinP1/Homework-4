using System;
using System.Linq;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that asks for the user's name and tells if the given name is a palindrome.
            //a word, phrase, or sequence that reads the same backwards as forwards, e.g. Anna, Ada etc.
            
            Console.WriteLine("Hello! Please enter your name:");
            string userAnswer = Console.ReadLine();
            string rev;
            
            //string[] Answer = new string[] {};
            char[] ch = userAnswer.ToCharArray();

            //Reverse an array
            Array.Reverse(ch);
            Console.WriteLine("Name reversed: ");
            rev = new string(ch);
            Console.WriteLine(rev);

            
            if (rev.ToUpper()==userAnswer.ToUpper())
            {
                Console.WriteLine($"{userAnswer} is a Palindrome!");
            }
            else
            {
                Console.WriteLine($"{userAnswer} is not a Palindrome!");
            }
            
            Console.ReadLine();


        }

        
    }
}