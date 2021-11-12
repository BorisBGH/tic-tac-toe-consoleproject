using System;

namespace TicTacToeConsole
{
    class Program
    {
        
        static Board myBoard = new Board(3);
      public  static int moveCounter = 1;

        static bool isGamePossible = true;
        static void Main(string[] args)
        {
            
            PrintBoard();

           while (isGamePossible)
            {
                int cellNumber =  MakeMove();
                
                ShowMoves(cellNumber);
                moveCounter++;
            }

          
           

            //string figure = "";
        }

        private static void ShowMoves(int cellNumber)
        {
            int rowCoordinate = cellNumber / myBoard.Size;
            int columnNumber = cellNumber % myBoard.Size-1;

            if (cellNumber % myBoard.Size == 0)
            {
                rowCoordinate -= 1;
               columnNumber = 2;
            }
         

            string figure = "";
            if (moveCounter % 2 != 0)
            {
                figure = "X";
            }
            else
            {
                figure = "0";
            }

            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.WriteLine("+---+---+---+");
                Console.Write("|");

                for (int j = 0; j < myBoard.Size; j++)
                {
                   if(i == rowCoordinate && j == columnNumber && myBoard.Grid[i,j].isEmpty)
                   {
                    Console.Write(" " + $"{figure}" +   " |");
                    myBoard.Grid[i, j].isEmpty = false;
                    myBoard.Grid[i, j].value = figure;
                      

                      

                   }
                    else if (myBoard.Grid[i, j].isEmpty == false)
                    {
                        Console.Write(" " + $"{myBoard.Grid[i,j].value}" + " |");
                    }
                   else
                    {
                        
                        Console.Write(" "  +  "  |");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("+---+---+---+");
           CheckGame();

        }

        private static void CheckGame()
        {
            //int winCounter = 0;

            //    for (int i = 0; i < myBoard.Size; i++)
            //    {
            //        for (int j = 0; j < myBoard.Size-1; j++)
            //        {
            //            if (myBoard.Grid[i,j].value == myBoard.Grid[i,j+1].value )
            //            {

            //            winCounter++;

            //            }
            //        }
            //    }
            //if (winCounter == 2)
            //{
            //    Console.WriteLine("Game over");
            //    isGamePossible = false;
            //}

            if (myBoard.Grid[0,0].value != null  && myBoard.Grid[0,0].value == myBoard.Grid[0,1].value &&  myBoard.Grid[0, 1].value == myBoard.Grid[0,2].value)
            {
                var checkedValue = myBoard.Grid[0, 0].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }
            
           if (myBoard.Grid[1,0].value != null && myBoard.Grid[1, 0].value == myBoard.Grid[1, 1].value && myBoard.Grid[1, 1].value == myBoard.Grid[1, 2].value)
            {
                var checkedValue = myBoard.Grid[1, 0].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }

            if (myBoard.Grid[2, 0].value != null && myBoard.Grid[2, 0].value == myBoard.Grid[2, 1].value && myBoard.Grid[2, 1].value == myBoard.Grid[2, 2].value)
            {
                var checkedValue = myBoard.Grid[2, 0].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }

            if (myBoard.Grid[0, 0].value != null && myBoard.Grid[0, 0].value == myBoard.Grid[1,0].value && myBoard.Grid[1, 0].value == myBoard.Grid[2, 0].value)
            {
                var checkedValue = myBoard.Grid[0, 0].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }
            if (myBoard.Grid[0, 1].value != null && myBoard.Grid[0, 1].value == myBoard.Grid[1, 1].value && myBoard.Grid[1, 1].value == myBoard.Grid[2, 1].value)
            {
                var checkedValue = myBoard.Grid[0, 1].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }
            if (myBoard.Grid[0, 2].value != null && myBoard.Grid[0, 2].value == myBoard.Grid[1, 2].value && myBoard.Grid[1, 2].value == myBoard.Grid[2, 2].value)
            {
                var checkedValue = myBoard.Grid[0, 2].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }
            if (myBoard.Grid[0, 0].value != null && myBoard.Grid[0, 0].value == myBoard.Grid[1, 1].value && myBoard.Grid[1, 1].value == myBoard.Grid[2, 2].value)
            {
                var checkedValue = myBoard.Grid[0, 0].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }
            if (myBoard.Grid[0, 2].value != null && myBoard.Grid[0, 2].value == myBoard.Grid[1, 1].value && myBoard.Grid[1, 1].value == myBoard.Grid[2, 0].value)
            {
                var checkedValue = myBoard.Grid[0, 2].value;
                Console.WriteLine($"Player {checkedValue} won!");
                Console.ReadLine();
                isGamePossible = false;
            }


            if (moveCounter == 9)
            {
                isGamePossible = false;
                Console.ReadLine();
                Console.WriteLine("All moves/Draw");
            }

         
            
        }

        private static int  MakeMove()
        {
            
            Console.WriteLine(moveCounter % 2 != 0 ? "Player X,chose your cell" : "Player 0, chose your cell");
            int chosedCell = int.Parse(Console.ReadLine());
            return chosedCell;

        }

     
       
        private static void PrintBoard()
        {
            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.WriteLine("+---+---+---+");
                Console.Write("|");

                for (int j = 0; j < myBoard.Size; j++)
                {
                    Console.Write(" "+ myBoard.Grid[i, j].cellNumber+ " |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("+---+---+---+");
        }
       
    }
}
