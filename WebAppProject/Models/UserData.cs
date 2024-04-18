using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class UserData
    {
        [Key]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birth date is required")]
        public string Birthday { get; set; }
    }
}
