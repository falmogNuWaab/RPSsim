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
        public Player Opponent { get; set; }

        public List<RPS> Possibles { get; set; } = new List<RPS> { RPS.Rock, RPS.Paper, RPS.Scissor };
        public RPSApp()
        {
            this.PlayerOne = new UserPlayer();
            //Player opFor;
            Console.WriteLine("Please pick an Opponent: \n[1]Rocky\n[2]Randa");           
            string response = Console.ReadLine();
            
            //bool stillChoosing = true;

                switch (response)
                {
                    case "1":
                        this.Opponent = new Rocky();
                        break;
                    case "2":
                        this.Opponent = new Randa();
                        break;
                    default:
                        Console.WriteLine("That's not a valid choice.");
                        break;
                }
           //this.Opponent = opFor;            
        }

        public Player Play()
        {
            UserPlayer drawPlayer = new UserPlayer("Draw");
            RPS playerRPS = PlayerOne.GenerateRPS();
            RPS opFor = Opponent.GenerateRPS();
            Console.WriteLine($"{Opponent.Name} chooses {opFor}");

            int uPlayer = Possibles.IndexOf(playerRPS);
            int opPlay = Possibles.IndexOf(opFor);

            string areTheOddsInYourFavor = WinTable[uPlayer, opPlay];


            Player winner = drawPlayer;

            switch (areTheOddsInYourFavor)
            {
                case "D":
                    winner = null;
                    break;
                case "W":
                    winner = PlayerOne;
                    break;
                case "L":
                    winner = Opponent;
                    break;
            }
            return winner;
        }

    }
}
