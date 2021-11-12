using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeConsole
{
   public class Cell
    {
        int Row { get; set; }
        int Column { get; set; }

    public int cellNumber { get; set; }

        public string value;
        
        public bool isEmpty = true;

    }
}
