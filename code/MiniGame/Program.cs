//create a method to impliment The computer will be your opponent and can randomly choose one of the elements (rock, paper, or scissors). Your game interaction will be through the console (Terminal).The player can choose one of the three options: rock, paper, or scissors, and should be warned if they enter an invalid option.At each round, the player must enter one of the options in the list and be informed if they won, lost, or tied with the opponent.By the end of each round, the player can choose whether to play again.Display the player's score at the end of the game.The minigame must handle user inputs, putting them in lowercase and informing the user if the option is invalid.In your GitHub Codespaces, follow the given instructions to set up prompts that GitHub Copilot can understand and use to help you build the minigame. Keep in mind that GitHub Copilot relies on comments to grasp the context and give you helpful suggestions while you're working on your project.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MiniGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            int playerScore = 0;
            string[] options = { "rock", "paper", "scissors" };
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Choose rock, paper, or scissors (or type 'exit' to quit):");
                string playerChoice = (Console.ReadLine() ?? string.Empty).ToLower();

                if (playerChoice == "exit")
                {
                    break;
                }

                if (!options.Contains(playerChoice))
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

                string computerChoice = options[random.Next(options.Length)];
                Console.WriteLine($"Computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                         (playerChoice == "paper" && computerChoice == "rock") ||
                         (playerChoice == "scissors" && computerChoice == "paper"))
                {
                    Console.WriteLine("You win!");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("You lose!");
                }

                Console.WriteLine($"Your score: {playerScore}");
            }

            Console.WriteLine($"Final score: {playerScore}");
        }
    }
}
