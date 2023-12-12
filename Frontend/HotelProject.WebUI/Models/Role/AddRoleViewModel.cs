using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Role
{
    public class AddRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
