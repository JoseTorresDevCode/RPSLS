using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class ComputerPlayer
    {
        //Member Variables 
        string playerName;
        string gesture;


        //Constructor



        //Member Methods 
        public string AI()

        {
            Console.WriteLine("What is your Name:?");
            playerName = Console.ReadLine();
            return playerName;
        }
    }

}
