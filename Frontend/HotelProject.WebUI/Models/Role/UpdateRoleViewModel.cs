using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Role
{
    public class UpdateRoleViewModel
    {
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
