using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="This field must not be empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field must not be empty")]
        public string Password { get; set; }
    }
}
