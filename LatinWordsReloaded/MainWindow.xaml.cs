using System;
using System.Collections.Generic;
using System.Linq;
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
using MahApps.Metro.Controls;

namespace LatinWordsReloaded
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1click(object sender, RoutedEventArgs e)
        {
            // latein abfragen
            latein_abfragen la = new latein_abfragen();
            la.Show();
        }

        private void btn2click(object sender, RoutedEventArgs e)
        {
            // latein einfügen
            latein_einfuegen le = new latein_einfuegen();
            le.Show();
        }

        private void btn3click(object sender, RoutedEventArgs e)
        {
            // englisch abfragen
        }

        private void btn4click(object sender, RoutedEventArgs e)
        {
            // englisch einfügen
        }


    }
}
