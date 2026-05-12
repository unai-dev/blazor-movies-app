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
                ReleaseDate = new DateTime(2025, 6, 30),
                PosterURL = "https://upload.wikimedia.org/wikipedia/en/a/a4/Captain_America_Brave_New_World_poster.jpg"
            },

            new Movie
            {
                Id = 2,
                Title = "Mission: Impossible - Dead Reckoning Part Two",
                ReleaseDate = new DateTime(2025, 5, 23),
                PosterURL = "https://upload.wikimedia.org/wikipedia/en/1/1f/Mission_Impossible_%E2%80%93_The_Final_Reckoning_Poster.jpg"
            }

            };
        }
    }
}
