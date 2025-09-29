using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Registration
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Los apellidos son requeridos")]
        [StringLength(50, ErrorMessage = "Los apellidos no pueden exceder 50 caracteres")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        public string Phone { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "El nombre de la empresa no puede exceder 100 caracteres")]
        public string Company { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Los comentarios no pueden exceder 500 caracteres")]
        public string Comments { get; set; } = string.Empty;

        [Range(typeof(bool), "true", "true", ErrorMessage = "Debes aceptar los términos y condiciones")]
        public bool AcceptTerms { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
