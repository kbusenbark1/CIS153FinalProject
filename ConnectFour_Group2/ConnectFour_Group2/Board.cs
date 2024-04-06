﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group2
{
    class Board
    {
        private const int numRows = 6;
        private const int numCols = 7;
        Cell[,] gameBoard = new Cell[numRows, numCols];

        //========GETTERS==========
        public int getNumRows()
        {
            return numRows;
        }
        public int getNumCols()
        {
            return numCols;
        }
        //Maybe I want to be able to get an individual cell from the gameboard given row and col
        public Cell getCell(int r, int c)
        {
            return gameBoard[r, c];
        }

        //Maybe we want to be able to view the entire board not just a cell
        public Cell[,] getGameBoard()
        {
            return gameBoard;
        }

        //========SETTERS==========
        //probably want to pass cells to game board not and entire board
        //however, you could definitely pass a full board
        public void setGameBoardCell(Cell cell)
        {
            //the only reason I can do this is because I am going to make sure that I 
            //set the row and col of a cell before I add it to the board
            gameBoard[cell.getRow(), cell.getCol()] = cell;
        }
    }

}
