using blazor_movies_app.Entities;
using blazor_movies_app.Services.Interfaces;

namespace blazor_movies_app.Services
{
    public class MovieService : IMovieService
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {

            new Movie
            {
                Id = 1,
                Title = "Captain America",
                ReleaseDate = new DateTime(2025, 2, 14)
            },

            new Movie
            {
                Id = 2,
                Title = "Mission: Impossible - Dead Reckoning Part Two",
                ReleaseDate = new DateTime(2025, 5, 23)
            }

            };
        }
    }
}
