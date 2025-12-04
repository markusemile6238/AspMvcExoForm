
using System.ComponentModel.DataAnnotations;

namespace EXOformulaire.Models.Contact
{
    public class PasswordValidatorAttribute : ValidationAttribute
    {


        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var password = value as string;

            if (string.IsNullOrEmpty(password))
            {
                return ValidationResult.Success;
            }

            var errors = new System.Collections.Generic.List<string>();

            if (password.Length < 8)
            {
                errors.Add("Le mot de passe doit contenir au moins 8 carcatères");
            }

            if (password.Length > 32)
            {
                errors.Add("Le mot de passe doit contenir au maximum 32 carcatères");
            }

            if (!password.Any(char.IsLower))
            {
                errors.Add("Le mot de passe doit contenir au moins un caractere minuscule");
            }

            if (!password.Any(char.IsUpper))
            {
                errors.Add("Le mot de passe doit contenir au moins un caractere de type majuscule");
            }

            if (!password.Any(char.IsDigit))
            {
                errors.Add("Le mot de passe doit contenir au moins un chiffre");
            }

            var specialCharacters = "@$!%*?&";
            if (!password.Any(c => specialCharacters.Contains(c)))
            {
                errors.Add("Le mot de passe doit contenir au moins un caracteres special parmis: @$!%*?& ");
            }

            if (!password.All(c => char.IsLetterOrDigit(c) || specialCharacters.Contains(c)))
            {
                errors.Add($"Le mot de passe contient des caractères non autorisés. Caractères autorisés : lettres, chiffres, {specialCharacters}");
            }

            if (errors.Any())
            {
                return new ValidationResult(string.Join("\n", errors));
            }

            return ValidationResult.Success;


        }
    }
}