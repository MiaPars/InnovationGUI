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

namespace InnovationGUI
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> madliste = new List<string>();
        public void Add()
        {
            madliste.Add("Æble");
            madliste.Add("Banan");
            madliste.Add("Pasta");
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMadliste_Click(object sender, RoutedEventArgs e)
        {
            Add();
            Screen.ItemsSource = madliste;
            
        }
        string p;
        private void ButtonUdløbsDato_Click(object sender, RoutedEventArgs e)
        {

            Add();
            

            
        }
        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private void Screen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (string item in madliste)
            {
                string s = item + RandomDay().ToString();
                p += item + RandomDay().ToString() + "\n";
            }
        }

        private void ButtonIndkøbsliste_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            bool newValue = true;
            Ananas.IsChecked = newValue;
            Slik.IsChecked = newValue;
            Pizza.IsChecked = newValue;
        }

        private void Slik_Checked(object sender, RoutedEventArgs e)
        {

        }

        

        private void Ananas_Checked(object sender, RoutedEventArgs e)
        {

        }

        string s;
        private void ButtonTilbudsavis_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://netto.dk/");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            s = TxtBoxNyMad.Text;
            
        }

        private void OKBTN_Click(object sender, RoutedEventArgs e)
        {
            //Add(s);
        }
    }
}
