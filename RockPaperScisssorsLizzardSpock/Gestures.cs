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
        public string gesture;
        public List<string> gestures;
        public List<bool> 
        //Constructor

        public Gestures(string gesture)
        {
            this.gesture = gesture;
            
        }
      
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
//Console.WriteLine($"Select Gesture: {gesture.gestures}" );