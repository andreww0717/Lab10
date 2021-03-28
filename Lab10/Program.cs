using System;

class MainClass
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

