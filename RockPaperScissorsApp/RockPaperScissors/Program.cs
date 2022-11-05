
using RockPaperScissors;

UserMessages.WelcomeMessage();
PlayerModel playerOne = UserMessages.InitializePlayer("Player 1");
PlayerModel computer = new PlayerModel { FirstName= "Computer"};


GameLogic.EvaluateTurnResult(playerOne,computer);
UserMessages.WinnerMessage(playerOne,computer);
