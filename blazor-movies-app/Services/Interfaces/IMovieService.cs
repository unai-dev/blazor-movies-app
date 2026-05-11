using blazor_movies_app.Entities;

namespace blazor_movies_app.Services.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
    }
}
