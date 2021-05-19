using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors1._1
{
    public class RandomPlayer: Player
    {
        public string RandomplayerName { get; set; }
        public RPS RAplayerHand { get; set; }

        public RandomPlayer() { }

        public RandomPlayer (string name, RPS hand)
        {
            playerName = name;
            playerHand = hand;
        }
        public override RPS GenerateRPS()
        {
            Random rnd = new Random();
            Type rps = typeof(RPS);
            Array values = rps.GetEnumValues();
            int index = rnd.Next(values.Length);
            RPS num = (RPS)values.GetValue(index);

            

            return num;

        }
    }
}
