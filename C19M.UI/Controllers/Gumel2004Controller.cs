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
        public IActionResult Index()
        {
            return View();
        }
    }
}