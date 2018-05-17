using System.Windows;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const byte MENU = 0, NEWGAME = 1, MUSIC = 2, OPTIONS = 3, QUIT = 4;
        int CurrentScreen = MENU;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Do you want to quit? Really?","Quit", MessageBoxButton.YesNo);
        }


    }
}
