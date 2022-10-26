using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MovieSystem.Interfaces;
using MovieSystem.Services;
using MovieSystem.Models;
using System.Linq.Expressions;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieRepo MovieService;
        public MoviesController() {
            MovieService = new MovieRepo();
        }
        // GET: api/<ValuesController>
        [HttpGet]
        [Route("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            try
            {
                List<Movie> movies = MovieService.GetAllMovies();
                return StatusCode(200, movies);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
            
        }

        // GET api/<ValuesController>/5
        [HttpGet]
        [Route("GetMovie/{id}")]
        public IActionResult GetMoviesById(int id)
        {
            try
            {
                return StatusCode(200, MovieService.GetMovieById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }

        // GET api/<ValuesController>
        [HttpGet]
        [Route("GetMoviesBy/{Property}/{Value}")]
        public IActionResult GetMoviesByProperty(string Property, string Value)
        {
            try
            {
                switch (Property) {
                    case "Actor":
                        return StatusCode(200, MovieService.GetMoviesByActor(Value));
                    case "Language":
                        return StatusCode(200, MovieService.GetMoviesByLang(Value));
                    case "Director":
                        return StatusCode(200, MovieService.GetMoviesByDirector(Value));
                    default:
                        throw new Exception("Invalid Property");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        // POST api/<ValuesController>/5
        [HttpPost]
        [Route("AddMovie")]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            try
            {
                MovieService.AddMovie(movie);
                return StatusCode(200, $"movie: {movie.MovieName} was added successfully ");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        [Route("EditMovie")]
        public IActionResult EditMovie([FromBody] Movie movie)
        {
            try
            {
                MovieService.EditMovie(movie);
                return StatusCode(200, $"movie id: {movie.MovieId} was edited successfully ");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        [Route("DeleteMovie/{id}")]
        public IActionResult DeleteMovie(int id)
        {
            try
            {
                MovieService.RemoveMovie(id);
                return StatusCode(200, $"movie id: {id} was deleted successfully ");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
