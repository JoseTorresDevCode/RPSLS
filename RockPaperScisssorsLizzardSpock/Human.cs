using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class Human : Player
    {
        //Member Variables 
        string playerName;


        //Constructor




        //Member Methods 
        public override string PlayerName()
        {
            Console.WriteLine("Player One Name:?");
            playerName = Console.ReadLine();

            return playerName;

        }

        public override string SelectGesture()
        {
            Console.WriteLine($"{playerName} please select a gesture");
            foreach (string gesture in gestures)
            {
                
                Console.WriteLine(gesture);
            }
            bool validChoice = false;
            while(validChoice == false) 
            {
                gesture = Console.ReadLine();
                if (gesture == "rock" || gesture == "scissors" || gesture == "paper" || gesture == "lizard" || gesture == "spock")
                {
                    validChoice = true;
                    Console.WriteLine($"{playerName} chose:" + gesture);
                    
                }
                else
                {
                    Console.WriteLine("your choice was invalid please choose again");
                    return SelectGesture();
                }
            }
            return gesture;

        }



        //public int MakeGesture(Player playerOneScore,  Player playerTwoScore)
        //{

        //Console.WriteLine("please select at gesture");
        //Console.WriteLine($"0 = Rock, 1 = Paper, 2 = Scissors, 3 = Lizard, 4 = Spock");
        //int response = Console.ReadLine();
        //Console.WriteLine("0 = Rock, 1 = Paper, 2 = Scissors, 3 = Lizard, 4 = Spock");
        //int response2 = Console.ReadLine();
        //if (response > response2)
        //{
        //    playerOneScore = 0++;
        //}
        //else if (response < response2)
        //{
        //    playerTwoScore = (0++);
        //}
        //else
        //{
        //    return MakeGesture();
        // }
        //}


    }
}
 