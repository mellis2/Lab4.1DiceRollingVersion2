using System;

namespace Lab4._1_Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            string rollAgain = "y";

            while (rollAgain == "y")
            {
                Console.Write("How many sides should each die have?: ");
                int numberOfSides = int.Parse(Console.ReadLine());
                int roll1 = RandomNumber(numberOfSides);
                int roll2 = RandomNumber(numberOfSides);
                int total = roll1 + roll2;
                Console.WriteLine($"You rolled a {roll1} and a {roll2} ({roll1 + roll2} total)");

                if (numberOfSides == 6)
                {
                    Output(roll1, roll2, total);
                }

                Console.Write("Roll Again? (y/n): ");
                rollAgain = Console.ReadLine();

                if (rollAgain == "n")
                {
                    Console.WriteLine("Thanks for playing!!");
                }

            }
        }


        static int RandomNumber(int numberOfSides)
        {
            Random random = new Random();

            return random.Next(1, numberOfSides + 1);
        }

        static void Output(int roll1, int roll2, int total)
        {


            if (roll1 == 1 && roll2 == 1)
            {
                Console.WriteLine("Snake Eyes");
            }
            else if ((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1))
            {
                Console.WriteLine("Ace Deuce");
            }
            else if (roll1 == 6 && roll2 == 6)
            {
                Console.WriteLine("Box Cars");
            }
            else if (total == 7 || total == 11)
            {
                Console.WriteLine("Win");
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                Console.WriteLine("Craps");
            }

        }
    }

}

