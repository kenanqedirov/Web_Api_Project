using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFSendMessageDal : GenericRepository<SendMessage> , ISendMessageDal
    {
        public EFSendMessageDal(Context context) : base(context) 
        {
            
        }

        public int GetSendMessageCount()
        {
            var context = new Context();
            return context.SendMessages.Count();
        }
    }
}
