namespace C19M.UI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public sealed class Gumel2006Controller : Controller
    {
        // GET: Gumel2006
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gumel2006
        public ActionResult Gumel2006()
        {
            return PartialView();
        }

        public ActionResult Figure6()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2006.Figure6());
        }
    }
}