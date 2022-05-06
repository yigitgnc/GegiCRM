using System.ComponentModel.DataAnnotations;

namespace GegiCRM.WebUI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "'{0}' Alanı Gereklidir !")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email Fromatı Hatalı !")]
        public string Email { get; set; }


        [Required(ErrorMessage = "'{0}' Alanı Gereklidir !"), MinLength(2, ErrorMessage = "{0} Mininmum {1} Karakter Uzunluğunda Olmalı Olmalı")]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "'{0}' Alanı Gereklidir !"), MinLength(2, ErrorMessage = "{0} Mininmum {1} Karakter Uzunluğunda Olmalı Olmalı")]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "'{0}' Alanı Gereklidir !"), MinLength(8, ErrorMessage = "{0} Mininmum {1} Karakter Uzunluğunda Olmalı Olmalı")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "'{0}' Alanı Gereklidir !")]
        [Display(Name = "Şifre")]
        [MinLength(6, ErrorMessage = "{0} Mininmum {1} Karakter Uzunluğunda Olmalı Olmalı")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Phone(ErrorMessage = "Telefon Formatı Hatalı !"), Required(ErrorMessage = "'{0}' Alanı Gereklidir !")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "'{0}' Alanı Gereklidir !")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor !")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "'{0}' Alanı Gereklidir !")]
        [Display(Name = "Gizlilik Politikası ve Kullanım Koşulları")]
        [Range(1,1,ErrorMessage = "{0} Onaylanmalı !")]
        public bool AgreedTerms { get; set; }

    }
}
