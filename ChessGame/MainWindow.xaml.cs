using Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ChessGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeChessBoard();
        }

        public void InitializeChessBoard()
        {
            
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Rectangle rect = new Rectangle();
                    if ((row + col) % 2 == 0)
                    {
                        rect.Fill = Brushes.Black;
                    }
                    else
                    {
                        rect.Fill = Brushes.White;
                    }
                    Grid.SetRow(rect, row);
                    Grid.SetColumn(rect, col);
                    ChessBoard.Children.Add(rect);
                }
            }
        }
    }
}
