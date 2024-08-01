using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Solver
{
    public class Board
    {
        public Cell[,] Cells { get; set; } = new Cell[9,9];
        public Board() 
        {
            for (int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++)
                {
                    Cells[i, j] = new Cell(j,i,0); 
                }
            }
        }
        public void Draw(Graphics gr)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Cells[i, j].Draw(gr);
                }
            }
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    gr.DrawRectangle(new Pen(Color.Black,5),j*Cell.length*3,i*Cell.length*3,Cell.length*3, Cell.length * 3);
                }
            }
        }
        public bool Solve()
        {
            Cell? emptyCell = GetEmptyCell();
            if (emptyCell == null)
            {
                return true;
            }
            //Debug.WriteLine(emptyCell.ColOffset);
            //Debug.WriteLine(emptyCell.RowOffset);
            int row = emptyCell.RowOffset;
            int col = emptyCell.ColOffset;

            for (int i = 1;i <= 9; i++)
            {
                if (IsValid(emptyCell,i))
                {
                    Debug.WriteLine(emptyCell.RowOffset);
                    Debug.WriteLine(emptyCell.ColOffset);
                    Cells[row,col].Value = i;
                    if (Solve())
                    {
                        return true;
                    }
                    Cells[row, col].Value = 0;
                }
            }
            return false;
        }

        private Cell? GetEmptyCell()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Cells[i, j].Value == 0)
                    {
                        return Cells[i, j];
                    }
                }
            }
            return null;
        }
        private bool IsValid(Cell current,int number)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Cells[current.RowOffset, i].Value == number && i != current.ColOffset)
                {
                    return false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (Cells[i, current.ColOffset].Value == number && i != current.RowOffset)
                {
                    return false;
                }
            }

            int box_x = current.ColOffset / 3;
            int box_y = current.RowOffset / 3;

            for (int i = box_y*3; i < box_y * 3+3; i++)
            {
                for (int j = box_x*3; j < box_x*3+3; j++)
                {
                    if (Cells[i,j].Value == number && Cells[i,j] != current)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
