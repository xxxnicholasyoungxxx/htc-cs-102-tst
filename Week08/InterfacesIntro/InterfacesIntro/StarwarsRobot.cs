using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class StarwarsRobot : Robot
    {
        int InNumberOfMovies { get; set; }

        public StarwarsRobot(int InNumberOfMovies, double StrideLength, int NumLegs)
        {
            this.InNumberOfMovies = InNumberOfMovies;
            this.StrideLength = StrideLength;
            this.NumLegs = NumLegs;
        }
    }
}
