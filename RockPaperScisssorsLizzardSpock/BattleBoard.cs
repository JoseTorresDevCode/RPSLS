using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RockPaperScisssorsLizzardSpock
{
    class BattleBoard
    {
        //Member Variables 
        public Player player1;
        public Player player2;

        //need winner
        //need score
        //need rounds
        //need conclusion
        // need player one /player two
        //need computer player/ maybe randome name? 
        //rules? 


        //Constructor
        public BattleBoard()
        {
            player1 = new Human();
                        
        }

        //Member Methods 
        public void Welcome()
        {
            Console.WriteLine("Welcome to the Ultimate Battle! Rock, Paper, Scissors, Lizard, Spock." + " " + "press enter to continue");
            Console.ReadLine();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules!");
            Console.WriteLine("Each Player will select a Gesture");
            Console.WriteLine("Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Rock");
            Console.WriteLine("Spock vaporizes Rock, and as always Rock smashes Scissors!" + " " + "press enter to continue");
            Console.ReadLine();
        }
        public void DeterminePlayer2()
        {
            Console.WriteLine("Do you want 1 player game or 2 player game? Type 1 or 2");
            string response = Console.ReadLine();
            {
                if (response == "2")
                {
                    player2 = new Human();
                    
                }
                else
                {
                    player2 = new ComputerPlayer();
                    
                }
               
            }

        }

        public void SetNames()
        {
            Human playerName = new Human();
            player1.PlayerName();
            player2.PlayerName();
        }

        public void Gestures()
        {
            player1.SelectGesture();
            player2.SelectGesture();
        }
        public void GivePoint()
        {
            player1.AddScore();
            player2.AddScore();
        }

        public void CompareGestures() 
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("you have Tied!");
            }
            else if (player1.gesture == "scissors" && player2.gesture == "paper")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "paper" && player2.gesture == "rock")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "rock" && player2.gesture == "lizard")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "lizard" && player2.gesture == "spock")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "spock" && player2.gesture == "scissors")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "scissors" && player2.gesture == "lizard")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "lizard" && player2.gesture == "paper")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "paper" && player2.gesture == "spock")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "spock" && player2.gesture == "rock")
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            else if (player1.gesture == "rock" && player2.gesture == "scissors") 
            {
                Console.WriteLine($"{player1.playerName}" + " " + "wins this round!");
                player1.AddScore();
            }
            
            else if (player2.gesture == "scissors" && player1.gesture == "paper")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "paper" && player1.gesture == "rock")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "rock" && player1.gesture == "lizard")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "lizard" && player1.gesture == "spock")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "spock" && player1.gesture == "scissors")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "scissors" && player1.gesture == "lizard")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "lizard" && player1.gesture == "paper")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "paper" && player1.gesture == "spock")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "spock" && player1.gesture == "rock")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            else if (player2.gesture == "rock" && player1.gesture == "scissors")
            {
                Console.WriteLine($"{player2.playerName}" + " " + "wins this round!");
                player2.AddScore();
            }
            

        }


        public void Rounds()
        {
            if(player1.score <= 2 || player2.score <= 2)
            {
                Console.WriteLine("next round! hit return to continue");
                Console.ReadLine();
                Gestures();
                CompareGestures();
            }
            else
            {
                DisplayWinner();
            }
        }
        public void DisplayWinner()
        {
            
            if (player1.score == 3)
            {
                Console.WriteLine(player1.playerName + " " + "Wins");
                Console.ReadLine();
                RestartGame();  
            }
            else if (player2.score == 3)
            {
                Console.WriteLine(player2.playerName + " " + "Wins");
                Console.ReadLine();
                RestartGame();
            }
            else
            {
                Gestures();
                CompareGestures();
            }
                
            
            
            
        }        
        
       
        public void RestartGame()
        {
            Console.WriteLine("would you like to restart the game? Yes or no");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "yes":
                    RunGame();
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("invalid entry");
                    RestartGame();
                    break;
            }
        }
          
        public void RunGame()
        {
            Welcome();
            DisplayRules();
            DeterminePlayer2();
            SetNames();
            Gestures();
            CompareGestures();
            Rounds();
            DisplayWinner();
            


        }      
    }

}
