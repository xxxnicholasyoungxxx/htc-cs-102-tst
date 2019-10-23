using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public double ReviewScore { get; set; }
        public double Length { get; set; }

        public List<string> Actors;

        public Movie(string title, string genre, double reviewscore, string director, double length)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reviewscore;
            Director = director;
            Length = length;

        }

        public void DisplayInformation()
        {
            MessageBox.Show($"Title:{Title} \n Genre:{Genre} \n ReviewScore:{ReviewScore} \n Director:{Director}");
        }
    }
}
