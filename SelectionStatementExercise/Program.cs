namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);
            Console.WriteLine("Guess what is your favorite numbwer: ?");
            var userInput= int.Parse(Console.ReadLine());
            if (userInput <= 10)
            {
                Console.WriteLine("too low");
            }
            else if(userInput >= 20) {
                Console.WriteLine("congratulations for guessing the correct numbe");
            }
            else if( userInput > 90)
            {
                Console.WriteLine("too high");
            }


            Console.WriteLine();

            Console.WriteLine("==================Exercise2 =====================================");
            Console.WriteLine("what is your favorite programming language: ");
            string language= Console.ReadLine();

            switch (language)
            {
                case "Pythone":
                    Console.WriteLine("Python is a high-level, versatile programming\n " +
                        "language known for its readability and"\n +
                        " simplicity, often used for web development, data analysis,\n " +
                        "and artificial intelligence.");
                    break;
                    \n
                case "C#":
                    Console.WriteLine("C# (pronounced C sharp) is a modern, object-oriented programming \n" +
                        "language developed by Microsoft. \nIt's widely used for building Windows applications, " +
                        "web development,\n and game development using the Unity game engine.\n");
                    break;
                case "JavaScript":
                    Console.WriteLine("JavaScript is a dynamic scripting language primarily\n " +
                        "used for web development. It runs in web browsers and enables\n" +
                        " interactive features, enhancing the user experience on websites.\n");
                    break;
                case "Java":
                    Console.WriteLine("Java is a versatile, object-oriented programming\n " +
                        "language known for its portability and write-once-run-anywhere \n" +
                        "philosophy. It is widely used in enterprise applications, \n" +
                        "mobile development (Android), and large-scale systems.\n");
                    break;
                case "C++":
                    Console.WriteLine("C++ is a powerful, general-purpose programming \n" +
                        "language that builds on the foundations of the C language.\n" +
                        " It is commonly used in systems programming, game development,\n " +
                        "and performance-critical applications" +
                        " due to its efficiency and control over hardware resources.\n");
                    break;
                
            }

        }
    }
}
