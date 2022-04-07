using System;
using System.Collections.Generic;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] scissorsRockPaper = new string[] { "scissors", "rock", "paper" };
            double counterUserWins = 0;
            double counterComputerWins = 0;
            double counterDraw = 0;
            double efficiency = 0;
            Console.WriteLine("Enter play to play a game, exit to exit the game or stats to check main statistics for the games played:");
            string playOrStatsOrExit = Console.ReadLine().Trim();
            while (playOrStatsOrExit.ToLower() != "play" && playOrStatsOrExit.ToLower() != "exit" && playOrStatsOrExit.ToLower() != "stats")
            {
                Console.WriteLine("Your entry is wrong! Please try again, enter play to play a game, exit to exit the game or stats to check main statistics for the games played:");
                playOrStatsOrExit = Console.ReadLine().Trim();
            }
            while (playOrStatsOrExit.ToLower() == "play" || playOrStatsOrExit.ToLower() == "exit" || playOrStatsOrExit.ToLower() == "stats")
            {
                if (playOrStatsOrExit.ToLower() == "exit")
                {
                    break;
                }
                else if (playOrStatsOrExit.ToLower() == "play")
                { 
                    Console.WriteLine("Enter scissors, rock or paper:");
                    string scissorsRockOrPaper = Console.ReadLine().Trim();
                    while (scissorsRockOrPaper.ToLower() != "scissors"
                        && scissorsRockOrPaper.ToLower() != "rock"
                        && scissorsRockOrPaper.ToLower() != "paper")
                    {
                        Console.WriteLine("Your entry is wrong! Please try again, enter scissors, rock or paper:");
                        scissorsRockOrPaper = Console.ReadLine().Trim();
                    }
                    if (scissorsRockOrPaper.ToLower() == "scissors")
                    {
                        Console.WriteLine("You've chosen scissors.");
                        int computerChoose = new Random().Next(0, 2);
                        if (computerChoose == 0)
                        {
                            counterDraw++;
                            Console.WriteLine("Computer has chosen scissors.");
                            Console.WriteLine("The game is draw.");
                        }
                        else if (computerChoose == 1)
                        {
                            Console.WriteLine("Computer has chosen rock.");
                            Console.WriteLine("The computer won this game.");
                            counterComputerWins++;
                        }
                        else if (computerChoose == 2)
                        {
                            Console.WriteLine("Computer has chosen paper.");
                            Console.WriteLine("You won this game.");
                            counterUserWins++;
                        }
                    }
                    else if (scissorsRockOrPaper.ToLower() == "rock")
                    {
                        Console.WriteLine("You've chosen rock.");
                        int computerChoose = new Random().Next(0, 2);
                        if (computerChoose == 0)
                        {
                            Console.WriteLine("Computer has chosen scissors.");
                            Console.WriteLine("You won this game.");
                            counterUserWins++;
                        }
                        else if (computerChoose == 1)
                        {
                            counterDraw++;
                            Console.WriteLine("Computer has chosen rock.");
                            Console.WriteLine("The game is draw.");
                        }
                        else if (computerChoose == 2)
                        {
                            Console.WriteLine("Computer has chosen paper.");
                            Console.WriteLine("The computer won this game.");
                            counterComputerWins++;
                        }
                    }
                    else if (scissorsRockOrPaper.ToLower() == "paper")
                    {
                        Console.WriteLine("You've chosen paper.");
                        int computerChoose = new Random().Next(0, 2);
                        if (computerChoose == 0)
                        {
                            Console.WriteLine("Computer has chosen scissors.");
                            Console.WriteLine("The computer won this game.");
                            counterComputerWins++;
                        }
                        else if (computerChoose == 1)
                        {
                            Console.WriteLine("Computer has chosen rock.");
                            Console.WriteLine("You won this game.");
                            counterUserWins++;
                        }
                        else if (computerChoose == 2)
                        {
                            counterDraw++;
                            Console.WriteLine("Computer has chosen paper.");
                            Console.WriteLine("This game is draw.");
                        }
                    }
                    Console.WriteLine("Enter play to play a game, exit to exit the game or stats to check main statistics for the games played:");
                    playOrStatsOrExit = Console.ReadLine().Trim();
                    while (playOrStatsOrExit.ToLower() != "play" && playOrStatsOrExit.ToLower() != "exit" && playOrStatsOrExit.ToLower() != "stats")
                    {
                        Console.WriteLine("Your entry is wrong! Please try again, enter play to play a game, exit to exit the game or stats to check main statistics for the games played:");
                        playOrStatsOrExit = Console.ReadLine().Trim();
                    }
                }
                else if (playOrStatsOrExit.ToLower() == "stats")
                {
                    Console.WriteLine($"No. of user wins: {counterUserWins} games.");
                    Console.WriteLine($"No. of computer wins: {counterComputerWins} games.");
                    Console.WriteLine($"No. of draws: {counterDraw} games.");
                    double totalGamesPlayed = counterUserWins + counterComputerWins + counterDraw;
                    if (totalGamesPlayed > 0)
                    {
                        efficiency = counterUserWins / totalGamesPlayed * 100;
                    }
                    else if (totalGamesPlayed == 0)
                    {
                        efficiency = 0;
                    }
                    Console.WriteLine($"The user has won {Math.Round(efficiency, 2)}% of the games played.");
                    Console.WriteLine("Enter play to play a game, exit to exit the game or stats to check statistics for the games played:");
                    playOrStatsOrExit = Console.ReadLine().Trim();
                    while (playOrStatsOrExit.ToLower() != "play" && playOrStatsOrExit.ToLower() != "exit" && playOrStatsOrExit.ToLower() != "stats")
                    {
                        Console.WriteLine("Your entry is wrong! Please try again, enter play to play a game, exit to exit the game or stats to check statistics for the games played:");
                        playOrStatsOrExit = Console.ReadLine().Trim();
                    }
                }
            }
        }
    }
}
