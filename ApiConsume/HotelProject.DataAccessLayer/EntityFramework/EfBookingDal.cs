using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly Context _context;
        public EfBookingDal(Context context) : base(context)
        {
            _context = context;
        }
        public void BookingStatusChangeApproved(int id)
        {
            var booking = _context.Bookings.Find(id);
            booking.Status = true;
            _context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var value = _context.Bookings.Count();
            return value;
        }

        public List<Booking> LastSixBookings()
        {
            var context = new Context();
            var values = context.Bookings.OrderByDescending(a=>a.BookingId).Take(6).ToList();
            return values;
        }
    }
}
