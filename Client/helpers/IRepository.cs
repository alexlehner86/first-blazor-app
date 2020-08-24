using System;
using System.Collections.Generic;
using firstBlazorApp.Shared.Entities;

namespace firstBlazorApp.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}