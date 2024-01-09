using Microsoft.AspNetCore.Mvc;

namespace Lab1.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
