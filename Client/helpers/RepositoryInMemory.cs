using System;
using System.Collections.Generic;
using firstBlazorApp.Shared.Entities;

namespace firstBlazorApp.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie{Title = "Avengers: Week of Ultron", ReleaseDate = new DateTime(2015, 5, 7)},
                new Movie{Title = "Spider-Man: Go for it, Girl!", ReleaseDate = new DateTime(2020, 2, 3)},
                new Movie{Title = "Batman & Robin: Revelations", ReleaseDate = new DateTime(1995, 11, 30)}
            };
        }
    }
}