using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokOgFilmInfo
{
    internal class Movie
    {
        public string Name { get; }
        public int ReleaseYear { get; }
        public string Description { get;  }
        public string Director { get; }
        public string Actors { get; }

        public Movie(string name, int releaseYear, string description, string director, string actors)
        {
            this.Name = name;
            this.ReleaseYear = releaseYear;
            this.Description = description;
            this.Director = director;
            this.Actors = actors;
           
        }
    }
}
