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
using MahApps.Metro;
using System.Collections;
using System.Diagnostics;

namespace LatinWordsReloaded
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(Accent ac in ThemeManager.DefaultAccents){
                Debug.Print(ac.Name);
            }
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

        private void menuitem1_click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.ElementAt(0), Theme.Dark);
        }

        private void menuitem2_click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.ElementAt(1), Theme.Dark);
        }

        private void menuitem3_click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.ElementAt(2), Theme.Dark);
        }

        private void menuitem4_click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.ElementAt(3), Theme.Dark);
        }

        private void menuitem5_click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme(this, ThemeManager.DefaultAccents.ElementAt(4), Theme.Dark);
        }


    }
}
