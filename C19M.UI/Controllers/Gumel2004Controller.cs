namespace C19M.UI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Hl7.Fhir.Model;

    public class Gumel2004Controller : Controller
    {
        // GET: Gumel2004
        public ActionResult Gumel2004()
        {
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

            ViewData["w1"] = dayCumulativeDiseaseInducedDeaths.Select(w => w.Item1.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date.ToString("MMM dd yyyy")).ToArray();

            ViewData["w2"] = dayCumulativeDiseaseInducedDeaths.Select(w => w.Item2.Value.Value).ToArray();

            return View();
        }
    }
}