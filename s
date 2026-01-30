using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-za-z]+$"
,           ErrorMessage = "Name must contain only alphabetic characters")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]){6,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    
        public string Password { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18,60, ErrorMessage = "Age must be between 18 and 60")]

        public int Age { get; set; }
    }


}
