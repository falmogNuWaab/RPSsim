using System;
using System.Collections.Generic;
using System.Text;

namespace JM_RPS_Lab
{
    class Randa : Player
    {
        public Randa() : base("Randa")
        {

        }
        public override RPS GenerateRPS()
        {
            Random rand = new Random();
            int om = rand.Next(0, 3);
            //om = 
            //RPS choice;
            switch (om)
            {
                case 0:
                    RockPaperScissor = RPS.Rock;
                    break;
                case 1:
                    RockPaperScissor = RPS.Paper;
                    break;
                case 2:
                    RockPaperScissor = RPS.Scissor;
                    break;
                default:
                    return GenerateRPS();
            }
            return RockPaperScissor;
        }

    }
}
