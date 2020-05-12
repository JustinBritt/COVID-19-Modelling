namespace C19M.UI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using System.Web;
    using System.Web.Mvc;

    // Hl7
    using Hl7.Fhir.Model;

    public sealed class Gumel2004Controller : Controller
    {
        // GET: Gumel2004
        public ActionResult Gumel2004()
        {
            return View();
        }

        public ActionResult Beijing()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.Beijing());
        }

        public ActionResult GreaterTorontoArea()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.GreaterTorontoArea());
        }

        public ActionResult HongKong()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.HongKong());
        }

        public ActionResult Singapore()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.Singapore());
        }
    }
}