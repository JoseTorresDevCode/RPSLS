﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class Program
    {
        static void Main(string[] args)
        {

            

            BattleBoard runGame = new BattleBoard();
            runGame.RunGame();
            Console.ReadLine();
            
        }
    }
}
