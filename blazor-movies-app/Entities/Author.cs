using System.ComponentModel.DataAnnotations;

namespace blazor_movies_app.Entities
{
    public class Author
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? Name { get; set; }
        public string? ImageURL { get; set; }
        public DateTime? Birhdate { get; set; }
    }
}
