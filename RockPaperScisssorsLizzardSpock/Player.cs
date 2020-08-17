using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    abstract class Player
    {

        public string gesture;
        public string score;
        public List<string> gestures;


        public Player()
        {
            int score = 0;
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            

        }




        public abstract string SelectGesture();

    }
}
