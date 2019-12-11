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

namespace OOPXmasExam2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> allPlayers = new List<Player>();
        List<Player> selectedPlayers = new List<Player>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


            string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };

            Player aPlayer = new Player("Adam ", "Brennan ", Position.Defender, new DateTime(1995, 05, 11), 24);
            Player bPlayer = new Player("Conor ", "Doyle ", Position.Forward, new DateTime(1995, 05, 11), 24);
            Player cPlayer = new Player("Emma ", "Kelly ", Position.Goalkeeper, new DateTime(1995, 05, 11), 24);
            Player dPlayer = new Player("Jack ", "McDonagh ", Position.Midfielder, new DateTime(1995, 05, 11), 24);
            Player ePlayer = new Player("Sophie ", "Walsh ", Position.Goalkeeper, new DateTime(1995, 05, 11), 24);

            allPlayers.Add(aPlayer);
            allPlayers.Add(bPlayer);
            allPlayers.Add(cPlayer);
            allPlayers.Add(dPlayer);
            allPlayers.Add(ePlayer);

            lbxAllPlayers.ItemsSource = allPlayers;

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Player selectedPlayer = lbxSelectedPlayers.SelectedItem as Player;
            /*
            if(selectedPlayer != null)
            {
                allPlayers.Remove(selectedPlayer);
                selectedPlayers.Add(selectedPlayer);

                */
        }
    }
}
