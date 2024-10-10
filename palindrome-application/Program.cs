using System;

namespace palindrome_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to my palindrome program!");

            Console.WriteLine("Please enter a word:");

            string userInput = Console.ReadLine().ToLower();

            char[] strArray = userInput.ToCharArray();

            Array.Reverse(strArray);

            string reversedStr = new string(strArray);

            if (String.Equals(userInput ,reversedStr))
            {
                Console.WriteLine(char.ToUpper(userInput[0]) + userInput.Substring(1) + " is a palindrome!");
            } 
            else
            {
                Console.WriteLine(char.ToUpper(userInput[0]) + userInput.Substring(1) + " is not a palidrome!");
            }

            Console.ReadLine();
        }
    }
}
