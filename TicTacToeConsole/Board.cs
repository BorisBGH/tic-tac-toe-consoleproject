using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeConsole
{
    class Board
    {
      public  int Size { get; set; }

     public   Cell[,] Grid;

        public int cellsCounter = 1;

        public Board(int size)
        {
            Size = size;
            Grid = new Cell[size, size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i, j] = new Cell();
                    Grid[i, j].cellNumber = cellsCounter;
                    cellsCounter++;
                    
                }
            }
        }



    }
}
