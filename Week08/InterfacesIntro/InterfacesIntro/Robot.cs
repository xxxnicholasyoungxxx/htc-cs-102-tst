using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    class Robot : Walks
    {
        public int NumLegs { get; set; }
        public double StrideLength { get; set; }
        public string Name { get; set; }
        public int Heigfht { get; set; }

        public void walk()
        {
            MessageBox.Show("Beep Boop Boop Bop Boop Boop Bop " + NumLegs + " legs");
        }
    }
}