using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

namespace BlackJackWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int waarde1 = 1;
        int waarde2 = 2;
        int waarde3 = 3;
        int waarde4 = 4;
        int waarde5 = 5;
        int waarde6 = 6;
        int waarde7 = 7;
        int waarde8 = 8;
        int waarde9 = 9;
        int waarde10 = 10;
        int boer = 10;
        int dame = 10;
        int heer = 10;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Kaarten(string[] args)
        {
            string[] Aas = new string[4] { "Klaveren-Aas", "Koeken-Aas", "Harten-Aas", "Schoppen-Aas" };
            string[] één = new string[4] { "Klaveren-1", "Koeken-1", "Harten-1", "Schoppen-1" };
            string[] twee = new string[4] { "Klaveren-2", "Koeken-2", "Harten-2", "Schoppen-2" };
            string[] drie = new string[4] { "Klaveren-3", "Koeken-3", "Harten-3", "Schoppen-3" };
            string[] vier = new string[4] { "Klaveren-4", "Koeken-4", "Harten-4", "Schoppen-4" };
            string[] vijf = new string[4] { "Klaveren-5", "Koeken-5", "Harten-5", "Schoppen-5" };
            string[] zes = new string[4] { "Klaveren-6", "Koeken-6", "Harten-6", "Schoppen-6" };
            string[] zeven = new string[4] { "Klaveren-7", "Koeken-7", "Harten-7", "Schoppen-7" };
            string[] acht = new string[4] { "Klaveren-8", "Koeken-8", "Harten-8", "Schoppen-8" };
            string[] negen = new string[4] { "Klaveren-9", "Koeken-9", "Harten-9", "Schoppen-9" };
            string[] tien = new string[4] { "Klaveren-10", "Koeken-10", "Harten-10", "Schoppen-10" };
            string[] boer = new string[4] { "Klaveren-Boer", "Koeken-Boer", "Harten-Boer", "Schoppen-Boer" };
            string[] dame = new string[4] { "Klaveren-Dame", "Koeken-Dame", "Harten-Dame", "Schoppen-Dame" };
            string[] heer = new string[4] { "Klaveren-Heer", "Koeken-Heer", "Harten-Heer", "Schoppen-Heer" };



            Random StringGenerator = new Random();
            Console.WriteLine(StringGenerator);


        }

        private string Geef(string operatie, int opertaie)
        {
            switch (operatie)
            {
                case "Klaveren-1\", \"Koeken-1\", \"Harten-1\", \"Schoppen-1":
                    return waarde1;
                case "\"Klaveren-2\", \"Koeken-2\", \"Harten-2\", \"Schoppen-2\"":
                    return waarde2;
                case "\"Klaveren-3\", \"Koeken-3\", \"Harten-3\", \"Schoppen-3\"":
                    return waarde3;
                case "\"Klaveren-4\", \"Koeken-4\", \"Harten-4\", \"Schoppen-4\"":
                    return waarde4;
                case "\"Klaveren-5\", \"Koeken-5\", \"Harten-5\", \"Schoppen-5\"":
                    return waarde5;
                case "\"Klaveren-6\", \"Koeken-6\", \"Harten-6\", \"Schoppen-6\"":
                    return waarde6;
                case "\"Klaveren-7\", \"Koeken-7\", \"Harten-7\", \"Schoppen-7\"":
                    return waarde7;
                case "\"Klaveren-8\", \"Koeken-8\", \"Harten-8\", \"Schoppen-8\"":
                    return waarde8;
                case "\"Klaveren-9\", \"Koeken-9\", \"Harten-9\", \"Schoppen-9\"":
                    return waarde9;
                case "\"Klaveren-10\", \"Koeken-10\", \"Harten-10\", \"Schoppen-10\"":
                    return waarde10
                case "\"Klaveren-Boer\", \"Koeken-Boer\", \"Harten-Boer\", \"Schoppen-Boer\"":
                    return boer
                case "\"Klaveren-Dame\", \"Koeken-Dame\", \"Harten-Dame\", \"Schoppen-Dame\"":
                    return dame
                case " \"Klaveren-Heer\", \"Koeken-Heer\", \"Harten-Heer\", \"Schoppen-Heer\"":
                    return heer
            }
        }

        private void BtnDeel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnHit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStand_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtResultaat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtSpelerScore_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtSpelerScore2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


//"Klaveren-Aas", "Klaveren-1", "Klaveren-2", "Klaveren-3", "Klaveren-4", "Klaveren-5", "Klaveren-6", "Klaveren-7", "Klaveren-8"

// + "Klaveren-9", "Klaveren-10", "Klaveren-Boer", "Klaveren-Dame", "Klaveren-Heer", "Koeken-Aas", "Koeken-1", "Koeken-2", "Koeken-3", "Koeken-4", "Koeken-5", "Koeken-6", "Koeken-7", "Koeken-8"
// + "Koeken-9", "Koeken-10", "Koeken-Boer", "Koeken-Dame", "Koeken-Heer", "Harten-Aas", "Harten-1", "Harten-2", "Harten-3", "Harten-4", "Harten-5", "Harten-6", "Harten-7", "Harten-8"
// + "Harten-9", "Harten-10", "Harten-Boer", "Harten-Dame", "Harten-Heer", "Schoppen-Aas", "Schoppen-1", "Schoppen-2", "Schoppen-3", "Schoppen-4", "Schoppen-5", "Schoppen-6", "Schoppen-7", "Schoppen-8"
// + "Schoppen-9", "Schoppen-10", "Schoppen-Boer", "Schoppen-Dame", "Schoppen-Heer"