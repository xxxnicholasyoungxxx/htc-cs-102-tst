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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            List<diamond> dia = new List<diamond>();

            List<spade> spa = new List<spade>();

            List<club> clu = new List<club>();

            List<heart> hea = new List<heart>();

            diamond dia1 = new diamond("diamond", 1);
            diamond dia2 = new diamond("diamond", 2);
            diamond dia3 = new diamond("diamond", 3);
            diamond dia4 = new diamond("diamond", 4);
            dia.Add(dia1);
            dia.Add(dia2);
            dia.Add(dia3);
            dia.Add(dia4);

            spade spa1 = new spade("spade", 1);
            spade spa2 = new spade("spade", 2);
            spade spa3 = new spade("spade", 3);
            spade spa4 = new spade("spade", 4);
            spa.Add(spa1);
            spa.Add(spa2);
            spa.Add(spa3);
            spa.Add(spa4);

            club clu1 = new club("club", 1);
            club clu2 = new club("club", 2);
            club clu3 = new club("club", 3);
            club clu4 = new club("club", 4);
            clu.Add(clu1);
            clu.Add(clu2);
            clu.Add(clu3);
            clu.Add(clu4);

            heart hea1 = new heart("heart", 1);
            heart hea2 = new heart("heart", 2);
            heart hea3 = new heart("heart", 3);
            heart hea4 = new heart("heart", 4);
            hea.Add(hea1);
            hea.Add(hea2);
            hea.Add(hea3);
            hea.Add(hea4);

            ICollection<myHand> mine = <myHand>();
            ICollection<comp> comp = <comp>();

        }

        public void playCard_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void slap_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
