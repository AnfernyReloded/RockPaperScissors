using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors1._1
{
    public class HumanPlayer:Player
    {
        public string HUplayerName { get; set; }

        public RPS HUplayerHand { get; set; }
        public override RPS GenerateRPS()
        {
            Console.WriteLine("Rock, Paper, Scissors");
            var localhand = Console.ReadLine().ToLower();
            RPS result;

            Enum.TryParse(localhand, out result);

             return result;

        }

    }
}
