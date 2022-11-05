using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class UserMessages
    {
        
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors game");
            Console.WriteLine("First player to 10 points wins!");
            Console.WriteLine();
        }
        public static PlayerModel InitializePlayer(string playerTitle)
            {
            PlayerModel output=new PlayerModel();
            Console.WriteLine($"{playerTitle} Are you ready to play! Please enter your first name: ");
            output.FirstName = Console.ReadLine();
            Console.WriteLine();
            return output;
            
            }

        public static string AskForASelection(PlayerModel player)
        {
            string output = "";
            Console.WriteLine($"{player.FirstName} would you like to play rock, paper, or scissors: ");
            output = Console.ReadLine().ToLower();
            //output = player.CurrentTurn;
            return output;

        }
        public static void DisplayTurnResults(PlayerModel playerOne, PlayerModel computer)
        {
            
            Console.WriteLine($"The {computer.FirstName} got: {computer.CurrentTurn}");
            Console.WriteLine();
        }

        public static void DisplayScore(PlayerModel playerOne, PlayerModel computer)
        {
            Console.WriteLine();
            Console.WriteLine("Here is the current score:");
            Console.WriteLine($"{playerOne.FirstName} has {playerOne.PlayerScore}");
            Console.WriteLine($"{computer.FirstName} has {computer.PlayerScore}");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static void WinnerMessage(PlayerModel playerOne, PlayerModel computer)
        {
            PlayerModel winner = new PlayerModel();
            if (playerOne.PlayerScore>=10 || computer.PlayerScore>=10)
            {
                Console.WriteLine();
                Console.WriteLine($"{playerOne.FirstName} has {playerOne.PlayerScore}");
                Console.WriteLine($"{computer.FirstName} has {computer.PlayerScore}");
                if (playerOne.PlayerScore>=10)
                {                    
                   Console.WriteLine($"{playerOne.FirstName} wins the game!");
                }
                else
                {                   
                    Console.WriteLine($"{computer.FirstName} wins the game!");
                }                                               
            }          
        }      
    }
}
