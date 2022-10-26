using MovieSystem.Models;
namespace MovieSystem.Interfaces
{
    public interface IMovieRepo
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        List<Movie> GetMoviesByActor(string ActorName);
        List<Movie> GetMoviesByLang(string Language);
        List<Movie> GetMoviesByDirector(string Director);
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void RemoveMovie(int MovieId);
    }
}
