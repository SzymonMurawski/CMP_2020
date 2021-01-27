using System;
using System.Collections.Generic;
using System.Text;

namespace WpfGameOfLife
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Id { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Id = GetId(x, y);
        }
        public Cell(string id)
        {
            string[] fields = id.Split('|');
            X = int.Parse(fields[0]);
            Y = int.Parse(fields[1]);
            Id = id;
        }
        public static string GetId(int x, int y)
        {
            return $"{x}|{y}";
        }
    }
}
