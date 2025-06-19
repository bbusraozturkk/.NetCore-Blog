using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi Girin")]
        public string password { get; set; }

    }
}
