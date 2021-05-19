using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors1._1
{
    public abstract class Player
    {
        public string playerName { get; set; }
        public RPS playerHand { get; set; }

        public Player() { }

        public Player(string Name, RPS Hand)
        {
            Name = playerName;
            Hand = playerHand;
        }

        public abstract RPS GenerateRPS();
    }
}
