using MovieSystemCodeFirstEF.Database;
using MovieSystemCodeFirstEF.Entities;
using MovieSystemCodeFirstEF.Interfaces;

namespace MovieSystemCodeFirstEF.Services
{
    public class MovieRepo : IMovieRepo
    {
        private MovieRepoDbContext context;

        public readonly string ServiceName = "MovieRepo";

        public MovieRepo()
        {
            context = new MovieRepoDbContext();
        }

        public void AddMovie(Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            foreach (var entry in context.Movies.Where(ele => ele.MovieId == movie.MovieId))
            {
                entry.MovieName = movie.MovieName;
                entry.Language = movie.Language;
                entry.ReleaseYear = movie.ReleaseYear;
                entry.Actor = movie.Actor;
                entry.Director = movie.Director;
            }
            context.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            return context.Movies.ToList();
        }

        public Movie GetMovieById(int MovieId)
        {
            return context.Movies.FirstOrDefault(entry => entry.MovieId == MovieId);
        }

        public List<Movie> GetMoviesByActor(string Actor)
        {
            return context.Movies.Where(entry => entry.Actor == Actor).ToList();
        }

        public List<Movie> GetMoviesByDirector(string Director)
        {
            return context.Movies.Where(entry => entry.Director == Director).ToList();
        }

        public List<Movie> GetMoviesByLang(string Language)
        {
            return context.Movies.Where(entry => entry.Language == Language).ToList();
        }

        public void RemoveMovie(int MovieId)
        {
            context.Movies.Remove(GetMovieById(MovieId));
            context.SaveChanges();
        }
    }
}