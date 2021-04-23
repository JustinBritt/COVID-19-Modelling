namespace ViewComponentSample.ViewComponents.Gumel2004
{
    using Microsoft.AspNetCore.Mvc;

    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BeijingViewComponent : ViewComponent
    {
        public BeijingViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string MyView = "Beijing2004";

            return View(
                MyView);
        }
    }
}