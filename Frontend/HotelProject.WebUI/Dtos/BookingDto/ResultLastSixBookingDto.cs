using System;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class ResultLastSixBookingDto
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdoultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool Status { get; set; }
    }
}
