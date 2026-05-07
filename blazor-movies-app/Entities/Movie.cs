namespace blazor_movies_app.Entities
{
    public class Movie
    {

        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime ReleaseDate { get; set; }


    }
}
