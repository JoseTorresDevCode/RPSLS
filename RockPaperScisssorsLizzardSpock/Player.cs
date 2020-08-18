using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RockPaperScisssorsLizzardSpock
{
    abstract class Player
    {

        public string gesture;
        public int score;
        public List<string> gestures;
        public string playerName;

        public Player()
        {

            score = 0;
            gestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spock" };
            

        }

        

        public abstract string SelectGesture();
        public abstract string PlayerName();
        public abstract int AddScore();
    }
}
