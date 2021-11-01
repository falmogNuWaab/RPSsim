using System;
using System.Collections.Generic;
using System.Text;

namespace JM_RPS_Lab
{
    class RPSApp
    {
        public string[,] WinTable { get; set; } = new string[3, 3] { { "D", "L", "D" },
                                                                     { "W", "D", "L" },
                                                                     { "L", "W", "D" } };
        public Player PlayerOne { get; set; }
        public int PlayerOneWins { get; set; } = 0;
        public Player Opponent { get; set; }
        public int OpponentWins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public RPSApp()
        {
            this.PlayerOne = new UserPlayer();
            this.Opponent = PickOpponent();
                   
        }
        public Player PickOpponent()
        {
            //Have PlayerOne pick their opponent
            //Creating a method that returns the player so that I can force the user to select an opponent
            //Previously, the following switch was in the constructor and I was using a a default opponent, set to new Randa();
            //if I didn't get a 1 or 2
            Console.WriteLine("\nChoose your Oppoent from the list:");
            Console.WriteLine("[1]Rocky\n[2]Randa");
            Console.Write("Selection: ");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    return new Rocky();

                case "2":
                    return new Randa();

                default:
                    Console.WriteLine("That's not a valid choice.");
                    break;
            }
            return PickOpponent();
        }
        public Player Play()
        {
            UserPlayer drawPlayer = new UserPlayer("Draw");
            PlayerOne.GenerateRPS();
            Opponent.GenerateRPS();
            Console.WriteLine($"{PlayerOne.Name} chooses {PlayerOne.RockPaperScissor}");
            Console.WriteLine($"{Opponent.Name} chooses {Opponent.RockPaperScissor}");

           string areTheOddsInYourFavor = WinTable[(int)PlayerOne.RockPaperScissor, (int)Opponent.RockPaperScissor];


            Player winner = drawPlayer;

            switch (areTheOddsInYourFavor)
            {
                case "D":
                    winner = drawPlayer;
                    Draws++;
                    break;
                case "W":
                    winner = PlayerOne;
                    PlayerOneWins++;
                    break;
                case "L":
                    winner = Opponent;
                    OpponentWins++;
                    break;
            }
            return winner;
        }

    }
}
