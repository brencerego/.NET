using System.ComponentModel.DataAnnotations;

namespace RegistrationApp.Models
{
    public class Register
    {
        [Required(ErrorMessage = "name is Required")]
        [RegularExpression (@"^[A-Za-z]+$",
            ErrorMessage = "Name must contain only alphabets")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]

        public string Email { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression (@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@!$&*?%]).{6,}$",
            ErrorMessage = "Password must contain atleast on uppercase and one lowercase letter and  on e number and on e special case character")]
            [MinLength(6, ErrorMessage = "Password must have atleast 6 letters ")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range ( 18 , 60 , ErrorMessage = "Age must be netween 18 and 60 years ")]

        public int Age { get; set; }


    }
}
