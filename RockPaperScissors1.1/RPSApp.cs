using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors1._1
{
    class RPSApp
    {   
        public static string GameLogic (RPS p1choice, RPS p2choice)
        {
            //same code as version#1
            string winner1 = "Player1 wins ";
            string winner2 = "Player 2 wins ";
            string tie = "Draw, go again";

            if (p1choice == p2choice)
            {
                return tie;
            }
            else if ((p1choice == RPS.rock && p2choice == RPS.scissors) || (p1choice == RPS.scissors && p2choice == RPS.paper) || (p1choice == RPS.paper && p2choice == RPS.rock))
            {
                return winner1;
            }
            else
            {
                return winner2;
            }


        }
        public void StartGame()
        {
            Player userPlayer = new HumanPlayer();
            Console.WriteLine("Please enter your name: ");
            string SGlocalname = Console.ReadLine();

            userPlayer.playerName = SGlocalname;

            while (true)
            {


                //sub loop for choice validation
            Console.WriteLine($"OK {SGlocalname}, select your opponent:\n Rock Player or Random Player ");

                string opponentChoice = Console.ReadLine().ToLower().Trim();


                Player chosenOpponent;
                if (opponentChoice == "rock player")
                {
                    RockPlayer cRock = new RockPlayer();
                    cRock.playerName = "Rock Player";
                    cRock.GenerateRPS();
                    chosenOpponent = cRock;
                    //string chosenOPName = cRock.RockplayerName;
                }
                else 
                {
                    RandomPlayer cRandom = new RandomPlayer();
                    cRandom.playerName = "Random Player";
                    cRandom.GenerateRPS();
                    chosenOpponent = cRandom;
                    //string chosenOPName = cRandom.RandomplayerName;
                } 
               

                RPS localPlayerHand = userPlayer.GenerateRPS();
                RPS localOppHand = chosenOpponent.GenerateRPS();
                
                

                


               var result = GameLogic(localPlayerHand, localOppHand);
               
               Console.WriteLine($"{chosenOpponent.playerName} threw {localOppHand}");
               Console.WriteLine($"{SGlocalname} threw {localPlayerHand}");
               Console.WriteLine(result);

               Console.WriteLine($"{SGlocalname} would you like to play again?");
               string playagain = Console.ReadLine().ToLower().Trim();
                
                if (playagain == "n")
                {
                    Console.WriteLine($"Thank you for playing {SGlocalname}, goodbye!");
                    break;
                }

                

                
                
                //gather user choice, assign it to userPlayer.HuplayerHand to be displayed?
                //save CPU player hand locally to be displayed?




            

            }
        }
        
    }
}
