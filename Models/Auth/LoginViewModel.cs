using EXOformulaire.Models.Contact;
using System.ComponentModel.DataAnnotations;

namespace EXOformulaire.Models.Auth
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "L'email est requis")]
        [EmailAddress(ErrorMessage = "Format d'email invalide")]
        [Display(Name = "Adresse email")]
        public required string LoginEmail { get; set; }

        [Display(Name = "LoginPassword")]
        [DataType(DataType.Password)]
        [PasswordValidator]
        public required string Password { get; set; }

    }
}
