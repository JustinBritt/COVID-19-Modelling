namespace C19M.UI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using Hl7.Fhir.Model;

    public sealed class Gumel2004Controller : Controller
    {
        // GET: Gumel2004
        public IActionResult Gumel2004()
        {
            return PartialView();
        }

        public IActionResult Beijing()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.BeijingModel());
        }

        public IActionResult GreaterTorontoArea()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.GreaterTorontoAreaModel());
        }

        public IActionResult HongKong()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.HongKongModel());
        }

        public IActionResult Singapore()
        {
            return PartialView(
                new C19M.UI.Models.Gumel2004.SingaporeModel());
        }
    }
}