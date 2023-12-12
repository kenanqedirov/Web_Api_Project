using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var values = _appUserService.TUserListsWithWorkLocations();
            Context context = new Context();
            var values = context.Users.Include(a => a.WorkLocation).Select(a => new AppUserWorkLocationViewModel
            {
                Name = a.Name,
                Surname = a.Surname,
                WorkDepartmant = a.WorkLocation.WorkLocationName,
                WorkLocationId = a.WorkLocation.WorkLocationId,
                City = a.City,
                Country = a.Country,
                Gender = a.Gender,
                ImageUrl = a.ImageUrl
            });
            return Ok(values);
        }
        [HttpGet("AppUserList")]
        public IActionResult AppUserList()
        {
            var valeus = _appUserService.TGetList();
            return Ok(valeus);
        }
    }
}
