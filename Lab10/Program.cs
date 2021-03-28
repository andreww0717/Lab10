using System;
// Class: CSE 1321L
// Section: #01
// Term: Spring 2021
// Instructor: Howard, Dexter
// Name: Andrew Winland
// Lab#: 10

class Lab10A
{
    public static void Main(string[] args)
    {
        string userInput;
        Console.Write("Enter a string:");
        userInput = Console.ReadLine();
        vowelRemover(userInput);
    }

    public static void vowelRemover(string userInput)
    {
        int count = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            switch (userInput[i])
            {
                case 'a':
                    count++;
                    Console.Write("*"); break;
                case 'e':
                    count++;
                    Console.Write("*"); break;
                case 'i':
                    count++;
                    Console.Write("*"); break;
                case 'o':
                    count++;
                    Console.Write("*"); break;
                case 'u':
                    count++;
                    Console.Write("*"); break;
                default:
                    Console.Write(userInput[i]);
                    break;
            }
        }
        Console.WriteLine($"\nThat string has {count} vowels.");
    }
}

