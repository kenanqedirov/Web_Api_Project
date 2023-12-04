using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="This field must not be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field must not be empty")]
        [Compare("Password",ErrorMessage ="Passwords are not same")]
        public string ConfirmPassword { get; set; }
    }
}
