using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="This field must not empty")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "This field must not empty")]
        [StringLength(50,ErrorMessage ="Use Maximum 50 character")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
