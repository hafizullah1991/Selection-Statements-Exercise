using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);

            Console.WriteLine("Guess what is your favorite number: ?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Congratulations for guessing the correct number");
            }
            else
            {
                Console.WriteLine("Too high");
            }

            Console.WriteLine();

            Console.WriteLine("================== Exercise 2 =====================================");
            Console.WriteLine("What is your favorite programming language: ");
            string language = Console.ReadLine();

            switch (language.ToLower()) // Make the comparison case-insensitive
            {
                case "python":
                    Console.WriteLine("Python is a high-level, versatile programming\n" +
                        "language known for its readability and\n" +
                        "simplicity, often used for web development, data analysis,\n" +
                        "and artificial intelligence.");
                    break;

                case "c#":
                    Console.WriteLine("C# (pronounced C sharp) is a modern, object-oriented programming\n" +
                        "language developed by Microsoft. It's widely used for building Windows applications, \n" +
                        "web development, and game development using the Unity game engine.\n");
                    break;

                case "javascript":
                    Console.WriteLine("JavaScript is a dynamic scripting language primarily\n" +
                        "used for web development. It runs in web browsers and enables\n" +
                        "interactive features, enhancing the user experience on websites.\n");
                    break;

                case "java":
                    Console.WriteLine("Java is a versatile, object-oriented programming\n" +
                        "language known for its portability and write-once-run-anywhere \n" +
                        "philosophy. It is widely used in enterprise applications, \n" +
                        "mobile development (Android), and large-scale systems.\n");
                    break;

                case "c++":
                    Console.WriteLine("C++ is a powerful, general-purpose programming \n" +
                        "language that builds on the foundations of the C language.\n" +
                        "It is commonly used in systems programming, game development,\n" +
                        "and performance-critical applications due to its efficiency and control over hardware resources.\n");
                    break;

                default:
                    Console.WriteLine("Not a recognized programming language.");
                    break;
            }
        }
    }
}