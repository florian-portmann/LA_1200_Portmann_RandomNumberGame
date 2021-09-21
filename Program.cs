using System;

namespace randomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int highscore = 1000000000;
            do
            {

                int Attempts = 1;
                int trueNumber = new Random().Next(1, 100);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Write a number between 1 and 100.");
                Console.ForegroundColor = ConsoleColor.White;
                
                    
                    string guessedNumber = Console.ReadLine();
                    int Guess = Convert.ToInt32(guessedNumber);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You wrote: " + guessedNumber + "");
                    Console.ForegroundColor = ConsoleColor.White;

                while (trueNumber != Guess)
                {
                        try
                        {



                            while ((Guess < 1) | (Guess > 100))
                            {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error, please write a number between 1 and 100");
                            Console.ForegroundColor = ConsoleColor.White;
                            guessedNumber = Console.ReadLine();
                            Guess = Convert.ToInt32(guessedNumber);
                            }


                            if (trueNumber > Guess)
                            {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("The number is too small");
                            Console.ForegroundColor = ConsoleColor.White;
                            guessedNumber = Console.ReadLine();
                            Guess = Convert.ToInt32(guessedNumber);
                            Attempts++;
                            }
                            if (trueNumber < Guess)
                            {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("The number is too big");
                            Console.ForegroundColor = ConsoleColor.White;
                            guessedNumber = Console.ReadLine();
                            Guess = Convert.ToInt32(guessedNumber);
                            Attempts++;
                            }

                        }
                        catch
                        {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not a number, please type a number");
                        Console.ForegroundColor = ConsoleColor.White;
                        guessedNumber = Console.ReadLine();
                        Guess = Convert.ToInt32(guessedNumber);
                        
                        }

                }


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Well done, you guessed the Number in " + Attempts + " attempts. ");
                Console.ForegroundColor = ConsoleColor.White;

                if (Attempts < highscore)
                {
                highscore = Attempts;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("New highscore: " + highscore + "");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("the highscore is still: " + highscore + "");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Möchten Sie nochmals spielen? Wenn Ja, dann schreiben Sie retry.");
                Console.ForegroundColor = ConsoleColor.White;
            } while (Console.ReadLine() == "retry");
            Environment.Exit(1);


         
        }
    }
}

