using System;
using System.Collections.Generic;
using System.Text;

namespace JM_RPS_Lab
{
    class UserPlayer : Player
    {
        public UserPlayer() : base("")
        {
            Console.WriteLine("What's your name?");
            string response = Console.ReadLine();
            this.Name = response;
        }
        
        public UserPlayer(string Name) : base(Name)
        {
            
        }

        public override RPS GenerateRPS()
        {
            Console.WriteLine("Please choose:\n[1]Rock\n[2]Paper\n[3]Scissor");
            string response = Console.ReadLine();
            //RPS choice;
            switch (response)
            {
                case "1":
                    RockPaperScissor = RPS.Rock;
                    break;
                case "2":
                    RockPaperScissor = RPS.Paper;
                    break;
                case "3":
                    RockPaperScissor = RPS.Scissor;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    return GenerateRPS();
            }
            return RockPaperScissor;
        }
    }
}
