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

    public sealed class Gumel2004Controller : Controller
    {
        // GET: Gumel2004
        public ActionResult Gumel2004()
        {
            return View(
                new Models.Gumel2004());
        }
    }
}