﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{

    public abstract class Player
    {

        //Abstrakt metod har ingen implementering utan tvingar underklasserna/de ärvande
        //Egenskap
        public string UserId { get; set; }

        //Konstruktor
        public Player(string userId)
        {
            UserId = userId;
        }

        //Metod för return användar-Id
        public string GetUserId()
        {
            return UserId;
        }
        //Metod för att ta stickor, måste implementeras av ComputerPlayer & HumanPlayer
        public abstract int TakePins(Board board);
    }
}
