namespace Data
{
    public class ChessBoard
    {
        private readonly Spot[,] _squares;

        public ChessBoard()
        {
            _squares = new Spot[8, 8];
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    _squares[row, col] = new Spot(row, col);
                }
            }
        }

        public Spot this[int row, int col]
        {
            get { return _squares[row, col]; }
            set { _squares[row, col] = value; }
        }
    }
}