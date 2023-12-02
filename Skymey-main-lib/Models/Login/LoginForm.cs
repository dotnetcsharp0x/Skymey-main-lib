using System.ComponentModel.DataAnnotations;

namespace Skymey_main_lib.Models.Login
{
    public class LoginForm
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
