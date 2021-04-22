namespace C19M.UI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public sealed class Gumel2006Controller : Controller
    {
        // GET: Gumel2006
        public IActionResult Index()
        {
            return View();
        }

        // GET: Gumel2006
        public IActionResult Gumel2006()
        {
            return PartialView();
        }

        public IActionResult Figure6()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2006.Figure6Model());
        }
    }
}