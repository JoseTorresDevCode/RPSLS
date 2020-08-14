using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class Human : Player
    {
        //Member Variables 
        string playerName;
        string gestureChoice;
         
        //Constructor




        //Member Methods 
        public string PlayerName()
        {
            Console.WriteLine("What is your Name:?");
            playerName = Console.ReadLine();
            return playerName;
        }

        public override void SelectGesture()
        {
            
        }

        //public int MakeGesture(Player playerOneScore,  Player playerTwoScore)
        //{

        //Console.WriteLine("please select at gesture");
        //Console.WriteLine($"0 = Rock, 1 = Paper, 2 = Scissors, 3 = Lizzard, 4 = Spock");
        //int response = Console.ReadLine();
        //Console.WriteLine("0 = Rock, 1 = Paper, 2 = Scissors, 3 = Lizzard, 4 = Spock");
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
 