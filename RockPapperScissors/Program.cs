using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
        GetInput:
            int playerScore = 0;
            int computerScore = 0;
            string exitKey = "";


            while (exitKey != "e")
            {
                Console.Clear();
                Console.WriteLine("Rock - Paper - Scissor");
                Console.WriteLine();
                Console.WriteLine("choose [r]ock , [p]aper, [s]cissors or [e]xit.");
                string playerMove = "";
                switch (Console.ReadLine().ToLower())
                {
                    case ("r"):
                        playerMove = "rock";
                        break;
                    case ("s"):
                        playerMove = "scissors";
                        break;
                    case ("p"):
                        playerMove = "paper";
                        break;
                    case ("e"):
                        exitKey = "e";
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("hatalı girdiniz");
                        goto GetInput;
                }
                Console.WriteLine($"your choose{playerMove}");
                Random rnd = new Random();
                int random = rnd.Next(3);
                string computerMove = "";
                switch (random)
                {
                    case 0:
                        computerMove = "rock";
                        break;
                    case 1:
                        computerMove = "paper";
                        break;
                    case 2:
                        computerMove = "scissors";
                        break;
                    default:
                        break;
                }

                if ((playerMove == "rock" && computerMove == "paper") || (playerMove == "rock" && computerMove == "paper") || (playerMove == "scissors" && computerMove == "rock"))
                {
                    computerScore++;
                    Console.WriteLine("you lose.Copmuter wins");
                }
                else if ((playerMove == "rock" && computerMove == "scissors") || (playerMove == "paper" && computerMove == "rock") || (playerMove == "scissors" && computerMove == "paper"))
                {
                    playerScore++;
                    Console.WriteLine("you win . Computer loose");
                }
                else
                {
                    Console.WriteLine("this game was a draw");
                }

                Console.WriteLine($" the computer score {playerScore} - computer Score {computerScore}");
                Console.ReadKey();
            }

        }
    }
}
