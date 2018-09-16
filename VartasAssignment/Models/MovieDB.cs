using System;
using System.Collections;
using System.Collections.Generic;


namespace VartasAssignment.Models
{
    public class MovieDB : IEnumerable
    {
        public List<Movie>  movieList = new List<Movie>();

        public MovieDB()
        {   
            //Lisätään testidataa
            Movie movie1 = new Movie("Deadpool", "Toiminta", "Supersankari leffa", "15:00", "17:00");
            Movie movie2 = new Movie("BlackKKKlansman", "Draama", "1980-luvulla poliisi soluttautuu...", "18:00", "20:00");
            this.movieList.Add(movie1);
            this.movieList.Add(movie2);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}