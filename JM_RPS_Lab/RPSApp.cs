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
        public Player uPlay { get; set; }
        public Player Opponent { get; set; }

        public List<RPS> Possibles { get; set; } = new List<RPS> { RPS.Rock, RPS.Paper, RPS.Scissor };
        public RPSApp()
        {
            this.uPlay = new UserPlayer();
            Player opFor = new Rocky();
            Console.WriteLine("Please pick an Opponent: \n[1]Rocky\n[2]Randa");           
            string response = Console.ReadLine();
            
            bool stillChoosing = true;
            //while (stillChoosing)
            //{
                switch (response)
                {
                    case "1":
                        opFor = new Rocky();
                        break;
                    case "2":
                        opFor = new Randa();
                        break;
                    default:
                        Console.WriteLine("That's not a valid choice.");
                        break;
                }
            //}
            this.Opponent = opFor;            
        }

        public Player Play()
        {
            RPS playerRPS = uPlay.GenerateRPS();
            RPS opFor = Opponent.GenerateRPS();
            Console.WriteLine($"{Opponent.Name} chooses {Opponent.RockPaperScissor}");

            int uPlayer = Possibles.IndexOf(playerRPS);
            int opPlay = Possibles.IndexOf(opFor);

            string areTheOddsInYourFavor = WinTable[uPlayer, opPlay];
            Player winner = new Rocky();

            //string response = "";
            switch (areTheOddsInYourFavor)
            {
                case "D":
                    return null;                    
                case "W":
                    winner = uPlay;
                    break;
                case "L":
                    winner = Opponent;
                    break;
            }
            return winner;
        }

    }
}
