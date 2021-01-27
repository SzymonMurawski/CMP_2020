using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GoLEngine engine;
        private int CellSize = 10;
        private int x0;
        private int y0;
        public MainWindow()
        {
            InitializeComponent();
            x0 = (int)gameBoard.Width / 2;
            y0 = (int)gameBoard.Height / 2;

            engine = new GoLEngine();
            engine.AddCell(0, 0);
            engine.AddCell(1, 0);
            engine.AddCell(2, 0);
            PrintEngine(engine);
        }

        public void PrintEngine(GoLEngine engine) 
        {
            gameBoard.Children.Clear();
            foreach(Cell cell in engine.Cells)
            {
                PrintCell(cell);
            }
        }

        public void PrintCell(Cell cell)
        {
            UIElement cellShape = new Ellipse
            {
                Fill = Brushes.Black,
                Width = CellSize,
                Height = CellSize
            };
            Canvas.SetLeft(cellShape, x0 + CellSize * cell.X);
            Canvas.SetTop(cellShape, y0 + CellSize * cell.Y);
            gameBoard.Children.Add(cellShape);
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            engine.GenerateNextState();
            PrintEngine(engine);
        }
    }
}
