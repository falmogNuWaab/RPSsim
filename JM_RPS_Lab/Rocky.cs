using System;
using System.Collections.Generic;
using System.Text;

namespace JM_RPS_Lab
{
    class Rocky : Player
    {
        public Rocky() : base("Rocky")
        {
            RockPaperScissor = RPS.Rock;
        }
        public override RPS GenerateRPS()
        {
            
            return RockPaperScissor;
        }

    }
}
