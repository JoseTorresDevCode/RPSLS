﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisssorsLizzardSpock
{
    class BattleBoard
    {
        //Member Variables 
        public Player player1;
        public Player player2;

        //need winner
        //need score
        //need rounds
        //need conclusion
        // need player one /player two
        //need computer player/ maybe randome name? 
        //rules? 


        //Constructor
        public BattleBoard()
        {
            player1 = new Human();
            player2 = new Human();
        }




        //Member Methods 
        public void Welcome()
        {
            Console.WriteLine("Welcome to the Ultimate Battle! Rock, Paper, Scissors, Lizzard, Spock.");
        }
        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules!");
            Console.WriteLine("Each Player will select a Gesture");
            Console.WriteLine("Scissors cuts Paper, Paper covers Rock, Rock crushes Lizzard, Lizzard poisons Spock");
            Console.WriteLine("Spock smashes Scissors, Scissors decapitates Lizzard, Lizzard eats Paper, Papers disproves Rock");
            Console.WriteLine("Spock vaporizes Rock, and as always Rock smashes Scissors");

        }
        public void DeterminePlayer2()
        {
            Console.WriteLine("Do you want 1 player game or 2 player game? Type 1 or 2");
            string response = Console.ReadLine();
            {
                if (response == "2")
                {
                    player2 = new Human();
                }
                else
                {
                    player2 = new ComputerPlayer();
                }

            }
          
        }
        public void RoundOne()
        {
            Console.WriteLine("PLease Select a Gesture");
            string response = Console.ReadLine();
            {
                if ()
                {


                }
            }

        }
        public void RoundTwo()
        {            // repeat

        }
        public void RoundThree()
        {           // repeat

        }

        public void RunGame()
        {
            DisplayRules();
        }



    }