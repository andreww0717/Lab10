using System;
// Class: CSE 1321L
// Section: #01
// Term: Spring 2021
// Instructor: Howard, Dexter
// Name: Andrew Winland
// Lab#: 10

namespace Lab10C
{
    class Lab10C
    {
        static void Main(string[] args)
        {


            string userInput;
            Console.Write("Enter a string: ");
            userInput = Console.ReadLine();

            foreach (char c in userInput.ToLower())
            {
                
                int unicode = c == 32 ? 32 :  ((c - 97 + 13) % 26) + 97;
                char n = (char)unicode;
                Console.Write(n);
               
                //https://stackoverflow.com/questions/5348844/how-to-convert-a-string-to-ascii
            }


            
        }
    }
}
