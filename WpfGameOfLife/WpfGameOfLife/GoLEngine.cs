using System;
using System.Collections.Generic;
using System.Text;

namespace WpfGameOfLife
{
    public class GoLEngine
    {
        public List<Cell> Cells;
        public int Turns { get; set; }
        public int LivingCells { get; set; }

        public GoLEngine()
        {
            Cells = new List<Cell>();
            Turns = 0;
            LivingCells = 0;
        }
        public void AddCell(int x, int y)
        {
            Cells.Add(new Cell(x, y));
            LivingCells++;
        }

    }
}
