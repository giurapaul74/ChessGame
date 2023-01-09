using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Spot
    {
        public int Row { get; }
        public int Column { get; }
        public ChessPiece Piece { get; set; }

        public Spot(int row, int col)
        {
            Row = row;
            Column = col;
            Piece = null;
        }
    }
}
