using System;
// Class: CSE 1321L
// Section: #01
// Term: Spring 2021
// Instructor: Howard, Dexter
// Name: Andrew Winland
// Lab#: 10

namespace Lab10B
{
    class Lab10B
    {
        public static void dangFinder(string userInput)
        {
        string badWord = "dang";
        string newWord = "&^#@";

            while (userInput.IndexOf(badWord) != -1)
            {
                int index = userInput.IndexOf(badWord);
                Console.WriteLine($"Found bad word at: {index}");
                userInput = userInput.Remove(index, 4).Insert(index, newWord.ToString());
            }
    Console.WriteLine(userInput);
            
        }
        public static void Main(string[] args)
{
    Console.Write("Enter a string: ");
    String userInput = Console.ReadLine();
            dangFinder(userInput);

}


    }
}
