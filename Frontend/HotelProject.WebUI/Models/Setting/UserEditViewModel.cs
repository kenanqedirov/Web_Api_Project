using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Setting
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage ="This field must not be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]

        public string Email { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]

        public string Username { get; set; }
        [Required(ErrorMessage = "This field must not be empty")]

        public string Password { get; set; }

        [Required(ErrorMessage = "This field must not be empty")]
        public string ConfirmPassword { get; set; }
    }
}
