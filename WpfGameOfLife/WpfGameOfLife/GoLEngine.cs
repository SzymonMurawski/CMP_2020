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

        public void GenerateNextState()
        {
            // Keys - cellId, value - number of neighbours
            Dictionary<string, int> cellNeighbours = new Dictionary<string, int>();
            foreach (Cell cell in Cells)
            {
                int[] positions = new int[] { -1, 0, 1 };
                foreach (int dx in positions)
                {
                    foreach (int dy in positions)
                    {
                        if(dx == 0 && dy == 0)
                        {
                            continue;
                        }
                        string neighbourCellId = Cell.GetId(cell.X + dx, cell.Y + dy);
                        if (cellNeighbours.ContainsKey(neighbourCellId))
                        {
                            cellNeighbours[neighbourCellId]++;
                        } else
                        {
                            cellNeighbours.Add(neighbourCellId, 1);
                        }
                    }
                }
            }

            List<Cell> newCells = new List<Cell>();
            foreach(Cell cell in Cells)
            {
                if (cellNeighbours.ContainsKey(cell.Id) && (cellNeighbours[cell.Id] == 2 || cellNeighbours[cell.Id] == 3))
                {
                    newCells.Add(cell);
                }
            }

            foreach(var entry in cellNeighbours)
            {
                if (entry.Value == 3 && !Cells.Exists(c => c.Id == entry.Key))
                {
                    newCells.Add(new Cell(entry.Key));
                }
            }
            Cells = newCells;
            Turns++;
            LivingCells = Cells.Count;
        }
    }
}
