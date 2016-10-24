using System;
using System.IO;
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

namespace Assignment5Group3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string DIRNAME = "Result";
        const string FILENAME = "DiceRollResult.txt";
        int dice1;
        int dice2;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void RandomNumber()
        {
            Random ran = new Random();
            dice1 = ran.Next(1, 7);
            dice2 = ran.Next(1, 7);
            if(dice1 == 1)
            {
                lblDice1.Content = "ONE";
                switch (dice2)
                {
                    case 1: lblDice2.Content = "ONE";
                        break;
                    case 2: lblDice2.Content = "TWO";
                        break;
                    case 3: lblDice2.Content = "THREE";
                        break;
                    case 4: lblDice2.Content = "FOUR";
                        break;
                    case 5: lblDice2.Content = "FIVE";
                        break;
                    case 6: lblDice2.Content = "SIX";
                        break;
                }
            }else if(dice1 == 2)
            {
                lblDice1.Content = "TWO";
                switch (dice2)
                {
                    case 1:
                        lblDice2.Content = "ONE";
                        break;
                    case 2:
                        lblDice2.Content = "TWO";
                        break;
                    case 3:
                        lblDice2.Content = "THREE";
                        break;
                    case 4:
                        lblDice2.Content = "FOUR";
                        break;
                    case 5:
                        lblDice2.Content = "FIVE";
                        break;
                    case 6:
                        lblDice2.Content = "SIX";
                        break;
                }
            }
            else if (dice1 == 3)
            {
                lblDice1.Content = "THREE";
                switch (dice2)
                {
                    case 1:
                        lblDice2.Content = "ONE";
                        break;
                    case 2:
                        lblDice2.Content = "TWO";
                        break;
                    case 3:
                        lblDice2.Content = "THREE";
                        break;
                    case 4:
                        lblDice2.Content = "FOUR";
                        break;
                    case 5:
                        lblDice2.Content = "FIVE";
                        break;
                    case 6:
                        lblDice2.Content = "SIX";
                        break;
                }
            }
            else if (dice1 == 4)
            {
                lblDice1.Content = "FOUR";
                switch (dice2)
                {
                    case 1:
                        lblDice2.Content = "ONE";
                        break;
                    case 2:
                        lblDice2.Content = "TWO";
                        break;
                    case 3:
                        lblDice2.Content = "THREE";
                        break;
                    case 4:
                        lblDice2.Content = "FOUR";
                        break;
                    case 5:
                        lblDice2.Content = "FIVE";
                        break;
                    case 6:
                        lblDice2.Content = "SIX";
                        break;
                }
            }
            else if (dice1 == 5)
            {
                lblDice1.Content = "FIVE";
                switch (dice2)
                {
                    case 1:
                        lblDice2.Content = "ONE";
                        break;
                    case 2:
                        lblDice2.Content = "TWO";
                        break;
                    case 3:
                        lblDice2.Content = "THREE";
                        break;
                    case 4:
                        lblDice2.Content = "FOUR";
                        break;
                    case 5:
                        lblDice2.Content = "FIVE";
                        break;
                    case 6:
                        lblDice2.Content = "SIX";
                        break;
                }
            }
            else if (dice1 == 6)
            {
                lblDice1.Content = "SIX";
                switch (dice2)
                {
                    case 1:
                        lblDice2.Content = "ONE";
                        break;
                    case 2:
                        lblDice2.Content = "TWO";
                        break;
                    case 3:
                        lblDice2.Content = "THREE";
                        break;
                    case 4:
                        lblDice2.Content = "FOUR";
                        break;
                    case 5:
                        lblDice2.Content = "FIVE";
                        break;
                    case 6:
                        lblDice2.Content = "SIX";
                        break;
                }
            }
        }

        private void btnRollDice_Click(object sender, RoutedEventArgs e)
        {
            RandomNumber();
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = System.IO.Path.Combine(path, DIRNAME);
            Directory.CreateDirectory(fullPath);
            string filePath = System.IO.Path.Combine(fullPath, FILENAME);
            StreamWriter sw = File.AppendText(filePath);
            string result = dice1.ToString() + " " + dice2.ToString(); 
            sw.WriteLine(result);
            sw.Close();
        }
    }
}
