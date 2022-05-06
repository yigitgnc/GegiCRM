using System.ComponentModel.DataAnnotations;

namespace GegiCRM.WebUI.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Email Alanı Gerekli !")]
        [EmailAddress(ErrorMessage ="Geçerli Bir Email Adresi Girmediniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gerekli !")]
        //[MinLength(6,ErrorMessage ="Şifre en az {1} Karakter Uunluğunda Olmalı")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
