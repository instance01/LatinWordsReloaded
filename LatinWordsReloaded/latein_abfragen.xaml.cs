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

namespace LatinWordsReloaded
{
    /// <summary>
    /// Interaktionslogik für latein_abfragen.xaml
    /// </summary>
    public partial class latein_abfragen : MetroWindow
    {
        public latein_abfragen()
        {
            InitializeComponent();
        }


        string allwords;
        string[] allwordsar;
        ArrayList goodwords = new ArrayList();
        Random random = new Random();

        private void txtbox2_keydown(object sender, KeyEventArgs e)
        {
            Label3.Content = goodwords.Count + "/" + allwordsar.Length;

            if (e.Key == Key.Enter)
            {
                //check for valid goodwords currentcount
                if (goodwords.Count == allwordsar.Length - 1)
                {
                    //Finished: all words gone through algorithm
                    if (MessageBox.Show("Finished. Restart?", "Finished.", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        
                    }
                    else
                    {
                        latein_abfragen la = new latein_abfragen();
                        la.Show();
                        this.Close();
                    }
                }
                else
                {
                    //check if the word is right
                    for (int i = 0; i <= allwordsar.Length - 1; i++)
                    {
                        string[] ar_ = allwordsar[i].ToString().Split('#');
                        string newar0 = ar_[0].ToString();
                        if (newar0 == TextBox1.Text)
                        {
                            //word found
                            //check word:

                            string[] ar = allwordsar[i].ToString().Split('#');
                            string[] newar1 = ar[1].ToString().Split(',');
                            bool word_ = false;
                            for (int a = 0; a <= newar1.Length - 1; a++)
                            {
                                if (TextBox2.Text == newar1[a].ToString())
                                {
                                    word_ = true;
                                }
                            }

                            if (word_)
                            {
                                goodwords.Add(allwords[i].ToString());
                                string newword = allwordsar[currentcount].ToString();
                                currentcount += 1;

                                if (newar1.Length > 1)
                                {
                                    TextBox4.Text += allwordsar[i].ToString() + Environment.NewLine;
                                    TextBox4.SelectionStart = TextBox4.Text.Length;
                                    TextBox4.ScrollToLine(TextBox4.GetLineIndexFromCharacterIndex(TextBox4.Text.Length - 1));
                                }
                                string[] newar = newword.Split('#');
                                TextBox1.Text = newar[0];
                                TextBox2.Text = "";
                                Label3.Content = goodwords.Count + "/" + allwordsar.Length;
                            }
                            else
                            {
                                if(!TextBox3.Text.Contains(allwordsar[i].ToString())){
                                    TextBox3.Text += allwordsar[i].ToString() + Environment.NewLine;
                                    TextBox3.SelectionStart = TextBox3.Text.Length;
                                    TextBox3.ScrollToLine(TextBox3.GetLineIndexFromCharacterIndex(TextBox3.Text.Length - 1));
                                }
                            }

                            return;
                        }
                    }
                }
            }
        }


        private void RandomizeArray(string[] items)
        {
            int max_index = items.Length - 1;
            Random rnd = new Random();
            for (int i = 0; i <= max_index - 1; i++)
            {
                // Pick an item for position i.
                int j = rnd.Next(i, max_index + 1);

                // Swap them.
                string temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        int currentcount = 0;
        private void abfragen_form_Load(object sender, RoutedEventArgs e)
        {
            allwords = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\latin_words.txt");
            allwordsar = allwords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);


            RandomizeArray(allwordsar);

            string[] newar = allwordsar[currentcount].ToString().Split('#');
            TextBox1.Text = newar[0];
            currentcount += 1;

            TextBox2.Focus();

            Label3.Content = goodwords.Count + "/" + allwordsar.Length;
        }
    }
}
