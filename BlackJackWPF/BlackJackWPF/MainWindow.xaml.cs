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
        private int WillekeurigGetal;
        private Random random;
        private int Aantalpogingen;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void RandomKaartGenerator(object sender, RoutedEventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f = 6;
            int g = 7;
            int h = 8;
            int i = 9;
            int j = 10;
            int k = 11;
        }

        private void BtnDeel(object sender, RoutedEventArgs e)
        {
            


        }

        private void BtnHit(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStand(object sender, RoutedEventArgs e)
        {

        }