using System;


namespace NumberGuesser
{

    class Program
    {
        // choose a point method
        static void Main(string[] args)
        {
            GetAppInfo();
            // username question 
            Console.WriteLine("What is your name?");
            // user input name
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            while (true)
            {

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;
                // guess number
                Console.WriteLine("Guess a number between 1 and 10");

                // not correct
                while (guess != correctNumber)
                {

                    // get user input
                    string input = Console.ReadLine();

                    // make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // randomly color
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        // tell user it's not a number
                        Console.WriteLine("Please enter an actual number");
                        Console.ResetColor();
                        continue;
                    }


                    // cast to int and put in guess
                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        // wrong number reply
                        Console.WriteLine("Wrong number, please try again");
                        Console.ResetColor();

                    }

                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                // correct number reply
                Console.WriteLine("You are CORRECT!!!");
                Console.ResetColor();


                // ask to play again
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


                Console.ReadKey();
            }

        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "faraj#1337";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            // app info thing bruhh
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}
