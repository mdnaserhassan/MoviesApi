using MoviesBusinessService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesBusinessService
{
    public interface IMovieManager
    {
        List<Movie> getMovies();
        Movie getMovie(string imdbid);
    }
}
