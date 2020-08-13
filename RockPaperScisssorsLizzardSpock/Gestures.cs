using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class Gestures
    {
        //Member Variables 
        
        public List<string> gestures;
        //Constructor
      
        public Gestures()
        {
            gestures = new List<string>();
            {
                gestures.Add("rock");
                gestures.Add("paper");
                gestures.Add("scissors");
                gestures.Add("lizzard");
                gestures.Add("spock");

            }
        }


        //Member Methods 
    }
}
