using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models
{
    public class SignInInput
    {
        [Required]
        [Display(Name ="Your email address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Your password")]
        public string Password { get; set; }
        [Display(Name = "Remind me")]
        public bool IsRemember { get; set; }
    }
}
