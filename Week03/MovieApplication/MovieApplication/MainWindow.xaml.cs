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

namespace MovieApplication
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

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            Movie submittedMovie = new Movie(titleTextBox1.Text, genreTextBox.Text, Double.Parse(reviewScoreTextBox.Text));

            /*submittedMovie.Title = titleTextBox1.Text;
            submittedMovie.Genre = genreTextBox.Text;
            submittedMovie.ReviewScore = Double.Parse(reviewScoreTextBox.Text);*/

            submittedMovie.DisplayInformation();

        }
    }
}
