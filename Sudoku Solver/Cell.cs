using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Sudoku_Solver
{
    public class Cell
    {
        public static int length = 65; 
        public int ColOffset {  get; set; }
        public int RowOffset { get; set; }
        public int? Value { get; set; }

        public Cell(int col,int row,int? value) 
        {
            ColOffset = col;
            RowOffset = row;
            Value = value;
        }
        public void Draw(Graphics gr)
        {
            gr.DrawRectangle(Pens.Black,ColOffset*length,RowOffset*length,length,length);
            if (Value != 0)
            {
                gr.DrawString(Value.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(ColOffset*length + (length / 2-5), RowOffset*length + (length / 2-5)));
            }
        }
    }
}
