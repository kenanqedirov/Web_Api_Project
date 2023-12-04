using Microsoft.AspNetCore.Mvc;
namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _FooterParial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
