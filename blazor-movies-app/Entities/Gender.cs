using blazor_movies_app.Validations;
using System.ComponentModel.DataAnnotations;

namespace blazor_movies_app.Entities
{
    public class Gender
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [FirstUpperValidation]
        public string? Name { get; set; }
    }
}
