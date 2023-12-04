using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Room Number is important")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Cover Image is important")]
        public string CoverImage { get; set; }
        [Required(ErrorMessage = "Price is important")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Title is important")]
        [StringLength(100,ErrorMessage ="Maximum 100 character")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bed Count is important")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Bath Count is important")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Description is important")]
        public string Description { get; set; }
    }
}
