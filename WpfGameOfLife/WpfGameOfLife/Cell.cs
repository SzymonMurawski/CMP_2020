using System;
using System.Collections.Generic;
using System.Text;

namespace WpfGameOfLife
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
