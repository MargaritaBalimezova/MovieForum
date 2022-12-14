using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieForum.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email/username and password combination doesn't match")]        
        public string Credential { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
