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
            int om = 0;
                om = rand.Next(0, 3);
            RPS choice;
            switch (om)
            {
                case 0:
                    choice = RPS.Rock;
                    break;
                case 1:
                    choice = RPS.Paper;
                    break;
                case 2:
                    choice = RPS.Scissor;
                    break;
                default:
                    return GenerateRPS();
            }
            return choice;
        }

    }
}
