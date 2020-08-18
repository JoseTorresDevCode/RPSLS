using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class ComputerPlayer : Player
    {
        //Member Variables 
        
        Random rand;

        //Constructor
        public ComputerPlayer()
        {
            

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
                    gesture = "lizard";
                    break;
                case 4:
                    gesture = "spock";
                    break;


            }
            Console.WriteLine($"{playerName} chose" + " " + gesture + " " + "-" + "press enter to continue");
            Console.ReadLine();
            return gesture;
        }

        public override string PlayerName()
        {
            Console.WriteLine("Player Two Name:?");
            playerName = Console.ReadLine();

            return playerName;
        }

        public override int AddScore()
        {
            score++;
            if (score >= 3)
            {
                Console.WriteLine($"{playerName}" + " " + "wins");
                Console.ReadLine();
                return score;
            }
            else
            {
                Console.WriteLine($"{playerName}'s score is: {score}!" + " " + "-" + "press enter to continue");
                Console.ReadLine();
                return score;
            }
        }

    }

}
