using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_try
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        public static int movieCount = 0;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
            movieCount++;
        }

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value == "G" || value == "R" || value == "NR" || value == "PG" || value == "PG-13") {
                    rating = value;
                } else {
                    rating = "NR";
                }
            }
        }
    }
}
