using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.WebUI.Models
{
    public class UserSignInWiewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
