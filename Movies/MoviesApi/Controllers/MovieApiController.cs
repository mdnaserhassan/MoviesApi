using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesBusinessService.Model;
using MoviesBusinessService;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieApiController : ControllerBase
    {



        private readonly ILogger<MovieApiController> _logger;
        private readonly IMovieManager _app;

        public MovieApiController(ILogger<MovieApiController> logger, IMovieManager app)
        {
            _logger = logger;
            _app = app;
        }

        [HttpGet]
        [Route("Movies", Name = "Movies")]
        public IEnumerable<Movie> GetMovies(string id)
        {
           
            return this._app.getMovies();

        }
        [HttpGet]
        [Route("Movies/{id}", Name = "GetMoviesbyId")]
        public Movie GetMoviesbyId(string id)
        {

            return this._app.getMovie(id);

        }

    }
}

