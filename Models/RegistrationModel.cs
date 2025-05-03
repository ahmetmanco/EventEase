using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Ad soyad gerekli")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email gerekli")]
        [EmailAddress(ErrorMessage = "Geçerli bir email girin")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Etkinlik adı gerekli")]
        public string EventName { get; set; } = string.Empty;
    }
}
