using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class GameLogic
    {
        public static string GenerateAValue()
        {           
            var random = new Random();
            List<string> rockPaperScissors = new List<string>() { "rock", "paper", "scissors" };
            int index = random.Next(rockPaperScissors.Count);
            string output=rockPaperScissors.ElementAt(index);
            return output;                
        }

        public static void TakeATurn(PlayerModel playerOne, PlayerModel computer)
        {
            playerOne.CurrentTurn = UserMessages.AskForASelection(playerOne);
                computer.CurrentTurn = GenerateAValue();            
        }

        public static void EvaluateTurnResult(PlayerModel playerOne, PlayerModel computer)
        {        
                do
                {
                    TakeATurn(playerOne, computer);
                    DealWithATie(playerOne, computer);                    
                    UserMessages.DisplayTurnResults(playerOne, computer);
                    DetermineRoundWinner(playerOne, computer);
                    UserMessages.DisplayScore(playerOne, computer);
                } while (DetermineIfPlayContinues(playerOne,computer));            
           
        }

        public static void DealWithATie(PlayerModel playerOne, PlayerModel computer)
        {
            while (playerOne.CurrentTurn == computer.CurrentTurn)
            {
                UserMessages.DisplayTurnResults(playerOne, computer);
                Console.WriteLine("It's a tie! Let's try again!");
                Console.WriteLine();
                TakeATurn(playerOne, computer);
            }
        }
       
        public static void DetermineRoundWinner(PlayerModel playerOne , PlayerModel computer)
        {           
                if ((playerOne.CurrentTurn == "rock" && computer.CurrentTurn == "scissors") || (playerOne.CurrentTurn == "paper" && computer.CurrentTurn == "rock") || (playerOne.CurrentTurn == "scissors" && computer.CurrentTurn == "paper"))
                {
                    Console.WriteLine($"{playerOne.FirstName} wins that round");
                    AddAPoint(playerOne);                  
                }                
                else
                {
                    Console.WriteLine($"{computer.FirstName} wins that round");
                    AddAPoint(computer);
                }          
        }
        public static int AddAPoint(PlayerModel player)
        {
            int output = 0;
            player.PlayerScore += 1;
            output = player.PlayerScore;
            return output;
        }       

        public static bool DetermineIfPlayContinues(PlayerModel playerOne, PlayerModel computer)
        {
            bool output = false;
            if (playerOne.PlayerScore<10 && computer.PlayerScore<10)
            {
                output = true;
            }
            return output;
        }      
    }
}
