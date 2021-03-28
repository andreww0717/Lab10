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
            //char a = 'a';
            //int asciiValue = (int) a;
            //Console.WriteLine('a');

            string userInput;
            Console.Write("Enter a string: ");
            userInput = Console.ReadLine();

           

            for (int i = 0; i < userInput.Length; i++)
            {
                switch (userInput[i])
                {
                    case 'a':
                        Console.Write("n"); break;
                    case 'b':
                        Console.Write("o"); break;
                    case 'c':
                        Console.Write("p"); break;
                    case 'd':
                        Console.Write("q"); break;
                    case 'e':
                        Console.Write("r"); break;
                    case 'f':
                        Console.Write("s"); break;
                    case 'g':
                        Console.Write("t"); break;
                    case 'h':
                        Console.Write("u"); break;
                    case 'i':
                        Console.Write("v"); break;
                    case 'j':
                        Console.Write("w"); break;
                    case 'k':
                        Console.Write("x"); break;
                    case 'l':
                        Console.Write("y"); break;
                    case 'm':
                        Console.Write("z"); break;
                    case 'n':
                        Console.Write("a"); break;
                    case 'o':
                        Console.Write("b"); break;
                    case 'p':
                        Console.Write("c"); break;
                    case 'q':
                        Console.Write("d"); break;
                    case 'r':
                        Console.Write("e"); break;
                    case 's':
                        Console.Write("f"); break;
                    case 't':
                        Console.Write("g"); break;
                    case 'u':
                        Console.Write("h"); break;
                    case 'v':
                        Console.Write("i"); break;
                    case 'w':
                        Console.Write("j"); break;
                    case 'x':
                        Console.Write("k"); break;
                    case 'y':
                        Console.Write("l"); break;
                    case 'z':
                        Console.Write("m"); break;
                    case ' ':
                        Console.Write(" "); break;

                }
            }
        }
    }
}
