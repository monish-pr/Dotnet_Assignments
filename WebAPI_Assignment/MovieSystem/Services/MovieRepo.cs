using MovieSystem.Interfaces;
using MovieSystem.Models;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;

namespace MovieSystem.Services
{
    public class MovieRepo : IService, IMovieRepo
    {
        public static List<Movie> MovieList = new List<Movie>();
        public string ServiceName { get; }

        public MovieRepo()
        {
            
            ServiceName = "MovieRepo";
        }

        public void AddMovie(Movie movie)
        {
            MovieList.Add(movie);
        }

        public void EditMovie(Movie movie)
        {
            foreach (var entry in MovieList.Where(ele => ele.MovieId == movie.MovieId)) {
                entry.MovieName = movie.MovieName;
                entry.Language = movie.Language;
                entry.ReleaseYear = movie.ReleaseYear;
                entry.Actor = movie.Actor;
                entry.Director = movie.Director;
            }
        }

        public List<Movie> GetAllMovies()
        {
            return MovieList;
        }

        public Movie GetMovieById(int MovieId)
        {
            return MovieList.FirstOrDefault(entry => entry.MovieId == MovieId);
        }

        public List<Movie> GetMoviesByActor(string Actor)
        {
            return MovieList.Where(entry => entry.Actor == Actor).ToList();
        }

        public List<Movie> GetMoviesByDirector(string Director)
        {
            return MovieList.Where(entry => entry.Director == Director).ToList();
        }

        public List<Movie> GetMoviesByLang(string Language)
        {
            return MovieList.Where(entry => entry.Language == Language).ToList();
        }

        public void RemoveMovie(int MovieId)
        {
            MovieList.Remove(GetMovieById(MovieId));
        }
    }
}
