using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors1._1
{
    public class RockPlayer : Player
    {
        public RockPlayer() { }

        public RockPlayer(string name, RPS hand)
        {
            playerName = name;
            playerHand = hand;
        }
        public override RPS GenerateRPS()
        {
            playerHand = RPS.rock;

            return RPS.rock;
        }

    }


}
