using EXOformulaire.Models.Contact;
using System.ComponentModel.DataAnnotations;

namespace EXOformulaire.Models.Auth
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Le nom est requis")]
        [Display(Name = "Nom complet")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "L'email est requis")]
        [EmailAddress(ErrorMessage = "Format d'email invalide")]
        [Display(Name = "Adresse email")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "La date de naissance est requise")]
        [DataType(DataType.Date)]
        [Display(Name = "Anniversaire")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; } = DateTime.Today;

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [PasswordValidator]
        public required string Password { get; set; }

        [Display(Name = "PasswordConfirmation")]
        [Compare("Password", ErrorMessage = "Le mot de passe et sa confirmation ne sont pas identique !.")]
        public required string PasswordConfirmation { get; set; }


    }
}
