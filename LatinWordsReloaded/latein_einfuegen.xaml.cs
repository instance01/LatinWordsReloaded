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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Collections;
using Microsoft.CSharp;
using System.IO;

namespace LatinWordsReloaded
{
    public partial class latein_einfuegen : MetroWindow
    {
        public latein_einfuegen()
        {
            InitializeComponent();
        }

        private void einfügen_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.S && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                //strg + s
                if (!string.IsNullOrEmpty(TextBox1.Text))
                {
                    File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt", Environment.NewLine + TextBox1.Text);
                    Label2.Content = "Saved at " + DateTime.Now;
                    TextBox2.Text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt");
                    TextBox1.Text = "";
                }

                e.Handled = true;
            }
        }

        private void einfügen_form_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt"))
            {
                TextBox2.Text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt");
            }
            else
            {
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt");
            }
        }

        private void btn1_click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt", Environment.NewLine + TextBox1.Text);
                Label2.Content = "Saved at " + DateTime.Now;
                TextBox2.Text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt");
                TextBox1.Text = "";
            }
        }


    }
}
