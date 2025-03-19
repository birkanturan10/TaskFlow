using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "İsim-soyisim gereklidir!")]
        public string? NameSurname { get; set; }

        [Required(ErrorMessage = "E-posta gereklidir!")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir!")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır!")]
        public string? Password { get; set; }
    }
}
