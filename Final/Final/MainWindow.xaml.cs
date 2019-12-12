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

namespace Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object Text { get; private set; }
        public int valu { get; set; }
        public string value { get; set; }
        public string suit { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        public void start_Click(object sender, RoutedEventArgs e)
        {
            List<diamond> dia = new List<diamond>();
            diamond dia1 = new diamond(1, 1);
            diamond dia2 = new diamond(1, 2);
            diamond dia3 = new diamond(1, 3);
            diamond dia4 = new diamond(1, 4);
            dia.Add(dia1);
            dia.Add(dia2);
            dia.Add(dia3);
            dia.Add(dia4);

            List<spade> spa = new List<spade>();
            spade spa1 = new spade(2, 1);
            spade spa2 = new spade(2, 2);
            spade spa3 = new spade(2, 3);
            spade spa4 = new spade(2, 4);
            spa.Add(spa1);
            spa.Add(spa2);
            spa.Add(spa3);
            spa.Add(spa4);

            List<club> clu = new List<club>();
            club clu1 = new club(3, 1);
            club clu2 = new club(3, 2);
            club clu3 = new club(3, 3);
            club clu4 = new club(3, 4);
            clu.Add(clu1);
            clu.Add(clu2);
            clu.Add(clu3);
            clu.Add(clu4);

            List<heart> hea = new List<heart>();
            heart hea1 = new heart(4, 1);
            heart hea2 = new heart(4, 2);
            heart hea3 = new heart(4, 3);
            heart hea4 = new heart(4, 4);
            hea.Add(hea1);
            hea.Add(hea2);
            hea.Add(hea3);
            hea.Add(hea4);
            
            deck.Text = value + " " + suit;
        }

        public void comp()
        {
            Random rnd = new Random();
            int valu = rnd.Next(1, 4);
            int clas = rnd.Next(1, 4);

            value = valu.ToString();
            suit = clas.ToString();
        }
    

        public void playCard_Click(object sender, RoutedEventArgs e)
        {

        }


        private void slap_Click(object sender, RoutedEventArgs e)
        {
            if (valu == 1)
            {
                deck.Text = "You win!";
            }
            else {}
        }
    }
}
