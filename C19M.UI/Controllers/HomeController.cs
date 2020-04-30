using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

using Hl7.Fhir.Model;

using C19M.M.C.A.Gumel2004.Interfaces.Contexts;

using C19M.M.C.A.Gumel2004.Interfaces.Exports;
using C19M.UI.Models;

namespace C19M.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // https://forums.asp.net/t/2125582.aspx?Pass+c+array+to+javascript+array+in+razor+file+
            ViewData["Labels"] = new string[] { "2010", "2011", "2012", "2013" };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DisplayChart_Gumel2004_HongKong_DayCumulativeDiseaseInducedDeaths()
        {
            ViewBag.Mesage = "";

            C19M.D.Gumel2004.Interfaces.IHongKong HK = new C19M.D.Gumel2004.Classes.HongKong();

            // Context
            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                HK.EndDate,
                HK.NumberDaysAfterStartDate,
                HK.StartDate,
                HK.DiseaseInducedDeathRateSymptomaticIndividuals,
                HK.DiseaseInducedDeathRateIsolatedIndividuals,
                HK.InitialValueAsymptomaticIndividuals,
                HK.InitialValueSymptomaticIndividuals,
                HK.InitialValueIsolatedIndividuals,
                HK.RecruitmentRateAsymptomaticIndividuals,
                HK.InitialValueQuarantinedIndividuals,
                HK.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                HK.InitialValueSusceptibleIndividuals,
                HK.BasicTransmissionCoefficient,
                HK.QuarantineRateAsymptomaticIndividuals,
                HK.IsolationRateSymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                HK.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                HK.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                HK.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                HK.NaturalDeathRate,
                HK.NetInflowRateSusceptibleIndividuals,
                HK.RecoveryRateSymptomaticIndividuals,
                HK.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                context);

            export.Solve();

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> dayCumulativeDiseaseInducedDeaths = export.DayCumulativeDiseaseInducedDeaths;

            // https://stackoverflow.com/a/9345910
            byte[] chart = new System.Web.Helpers.Chart(
                width: 1000,
                height: 300,
                theme: ChartTheme.Vanilla)
                .AddSeries(
                chartType: "line",
                xValue: dayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().Date.Date).ToArray(),
                yValues: dayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray())
                .ToWebImage()
                .GetBytes("image/png");

            // Return byte array as png.
            return File(
                chart,
                "image/png");
        }

        public ActionResult DisplayChart_Gumel2004_HongKong_DayCumulativeProbableCases()
        {
            ViewBag.Mesage = "";

            C19M.D.Gumel2004.Interfaces.IHongKong HK = new C19M.D.Gumel2004.Classes.HongKong();

            // Context
            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                HK.EndDate,
                HK.NumberDaysAfterStartDate,
                HK.StartDate,
                HK.DiseaseInducedDeathRateSymptomaticIndividuals,
                HK.DiseaseInducedDeathRateIsolatedIndividuals,
                HK.InitialValueAsymptomaticIndividuals,
                HK.InitialValueSymptomaticIndividuals,
                HK.InitialValueIsolatedIndividuals,
                HK.RecruitmentRateAsymptomaticIndividuals,
                HK.InitialValueQuarantinedIndividuals,
                HK.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                HK.InitialValueSusceptibleIndividuals,
                HK.BasicTransmissionCoefficient,
                HK.QuarantineRateAsymptomaticIndividuals,
                HK.IsolationRateSymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                HK.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                HK.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                HK.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                HK.NaturalDeathRate,
                HK.NetInflowRateSusceptibleIndividuals,
                HK.RecoveryRateSymptomaticIndividuals,
                HK.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                context);

            export.Solve();

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> E = export.DayAsymptomaticIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> I = export.DaySymptomaticIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> J = export.DayIsolatedIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> Q = export.DayQuarantinedIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> R = export.DayRecoveredIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> S = export.DaySusceptibleIndividuals;

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> dayCumulativeProbableCases = export.DayCumulativeProbableCases;

            // https://stackoverflow.com/a/9345910
            byte[] chart = new System.Web.Helpers.Chart(
                width: 1000,
                height: 300,
                theme: ChartTheme.Vanilla)
                .AddSeries(
                chartType: "line",
                xValue: dayCumulativeProbableCases.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().Date.Date).ToArray(),
                yValues: dayCumulativeProbableCases.Select(w => w.Item2.Value.Value).ToArray())
                .ToWebImage()
                .GetBytes("image/png");

            // Return byte array as png.
            return File(
                chart, 
                "image/png");
        }

        public ActionResult DisplayChart_Gumel2004_HongKong_DayAsymptomaticIndividuals()
        {
            ViewBag.Mesage = "";

            C19M.D.Gumel2004.Interfaces.IHongKong HK = new C19M.D.Gumel2004.Classes.HongKong();

            // Context
            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                HK.EndDate,
                HK.NumberDaysAfterStartDate,
                HK.StartDate,
                HK.DiseaseInducedDeathRateSymptomaticIndividuals,
                HK.DiseaseInducedDeathRateIsolatedIndividuals,
                HK.InitialValueAsymptomaticIndividuals,
                HK.InitialValueSymptomaticIndividuals,
                HK.InitialValueIsolatedIndividuals,
                HK.RecruitmentRateAsymptomaticIndividuals,
                HK.InitialValueQuarantinedIndividuals,
                HK.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                HK.InitialValueSusceptibleIndividuals,
                HK.BasicTransmissionCoefficient,
                HK.QuarantineRateAsymptomaticIndividuals,
                HK.IsolationRateSymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                HK.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                HK.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                HK.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                HK.NaturalDeathRate,
                HK.NetInflowRateSusceptibleIndividuals,
                HK.RecoveryRateSymptomaticIndividuals,
                HK.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                context);

            export.Solve();

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> dayAsymptomaticIndividuals = export.DayAsymptomaticIndividuals;

            // https://stackoverflow.com/a/9345910
            byte[] chart = new System.Web.Helpers.Chart(
                width: 1000,
                height: 300,
                theme: ChartTheme.Vanilla)
                .AddSeries(
                chartType: "line",
                xValue: dayAsymptomaticIndividuals.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().Date.Date).ToArray(),
                yValues: dayAsymptomaticIndividuals.Select(w => w.Item2.Value.Value).ToArray())
                .ToWebImage()
                .GetBytes("image/png");

            // Return byte array as png.
            return File(
                chart,
                "image/png");
        }

        // TODO: Finish
        public JsonResult DisplayChart_Gumel2004_HongKong_DayCumulativeDiseaseInducedDeaths_Json()
        {
            List<GraphData_Model> values = new List<GraphData_Model>();

            C19M.D.Gumel2004.Interfaces.IHongKong HK = new C19M.D.Gumel2004.Classes.HongKong();

            // Context
            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                HK.EndDate,
                HK.NumberDaysAfterStartDate,
                HK.StartDate,
                HK.DiseaseInducedDeathRateSymptomaticIndividuals,
                HK.DiseaseInducedDeathRateIsolatedIndividuals,
                HK.InitialValueAsymptomaticIndividuals,
                HK.InitialValueSymptomaticIndividuals,
                HK.InitialValueIsolatedIndividuals,
                HK.RecruitmentRateAsymptomaticIndividuals,
                HK.InitialValueQuarantinedIndividuals,
                HK.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                HK.InitialValueSusceptibleIndividuals,
                HK.BasicTransmissionCoefficient,
                HK.QuarantineRateAsymptomaticIndividuals,
                HK.IsolationRateSymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                HK.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                HK.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                HK.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                HK.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                HK.NaturalDeathRate,
                HK.NetInflowRateSusceptibleIndividuals,
                HK.RecoveryRateSymptomaticIndividuals,
                HK.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                context);

            export.Solve();

            ImmutableList<System.Tuple<FhirDateTime, FhirDecimal>> dayCumulativeDiseaseInducedDeaths = export.DayCumulativeDiseaseInducedDeaths;

            foreach (var item in dayCumulativeDiseaseInducedDeaths)
            {
                GraphData_Model gdm = new GraphData_Model();
                gdm.x = item.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy");
                gdm.y = item.Item2.Value.Value;

                values.Add(
                    gdm);
            }

            return Json(
                values,
                JsonRequestBehavior.AllowGet);
        }
    }
}