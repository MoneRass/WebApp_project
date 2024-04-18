using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class UserToken
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
