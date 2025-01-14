using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession; // Create a new GameSession object
        //private because we don't want to expose this object to other classes

        public MainWindow()
        {
            InitializeComponent();
            
            _gameSession = new GameSession(); // Initialize the GameSession object

            DataContext = _gameSession; // Set the DataContext of the MainWindow to the GameSession object
        }

        //private becuase only visibl to the MainWindow class
        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            

        }
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {


        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {


        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {


        }
    }
}