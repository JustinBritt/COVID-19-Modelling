namespace C19M.UI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using System.Web;
    using System.Web.Mvc;

    using Hl7.Fhir.Model;

    public class Gumel2004Controller : Controller
    {
        // GET: Gumel2004
        public ActionResult Gumel2004()
        {
            C19M.UI.Models.Gumel2004 gumel2004 = new Models.Gumel2004();

            ViewData["days"] = gumel2004.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy")).ToArray();

            ViewData["HongKong_DayCumulativeDiseaseInducedDeaths"] = gumel2004.HongKong_DayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

            return View(
                gumel2004);
        }
    }
}