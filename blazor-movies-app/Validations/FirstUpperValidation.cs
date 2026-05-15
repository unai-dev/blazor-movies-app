using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace blazor_movies_app.Validations
{
    public class FirstUpperValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var valueToString = value.ToString()!;
            string firstChar = valueToString[0].ToString();

            if (firstChar != firstChar.ToUpper())
            {
                return new ValidationResult(
                    "La primera letra debe ser mayuscula", [validationContext.MemberName!]);

            }

            return ValidationResult.Success;
        }
    }
}