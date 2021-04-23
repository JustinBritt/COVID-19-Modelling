namespace ViewComponentSample.ViewComponents.Gumel2004Beijing
{
    using Microsoft.AspNetCore.Mvc;

    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Gumel2004BeijingViewComponent : ViewComponent
    {
        public Gumel2004BeijingViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}