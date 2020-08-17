using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class ComputerPlayer : Player
    {
        //Member Variables 
        string playerName;
        string gesture;
        Random rand;

        //Constructor
        public ComputerPlayer()
        {
            playerName = "Brett";
            rand = new Random();
        }
        


        //Member Methods 
       


        public override string SelectGesture()
        {
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            int autoGesture = rand.Next(5);
            switch(autoGesture)
            {
                case 0:
                    gesture = "rock";
                    break;
                case 1:
                    gesture = "paper";
                    break;
                case 2:
                    gesture = "scissors";
                    break;
                case 3:
                    gesture = "lizzard";
                    break;
                case 4:
                    gesture = "spock";
                    break;


            }
            Console.WriteLine("Brett Chose" + gesture);
            Console.ReadLine();
            return gesture;
        }  





    }

}
