using EShope.Contex;
using Microsoft.AspNetCore.Mvc;

namespace EShope.ViewComponents
{
    public class MainSliderViewComponent:ViewComponent
    {

        private ApplicationDbContext _context;

        public MainSliderViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }












public  IViewComponentResult Invoke()
        {

            var banner = _context.Banners.ToList();
            return View("MainSlider",banner);

        }

    }
}
