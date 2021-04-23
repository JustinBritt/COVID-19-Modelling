namespace ViewComponentSample.ViewComponents.Gumel2004
{
    using Microsoft.AspNetCore.Mvc;

    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Gumel2004ViewComponent : ViewComponent
    {
        public Gumel2004ViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}