﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class AddRoomDto
    {
        [Required(ErrorMessage ="Room Number is important")]
        public string RoomNumber { get; set; }
        public string CoverImage { get; set; }
        [Required(ErrorMessage = "Price is important")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Title is important")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bed Count is important")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Bath Count is important")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
