namespace C19M.M.C.A.Gumel2006.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    // Hl7
    using Hl7.Fhir.Model;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            C19M.D.Gumel2006.Interfaces.IGreaterTorontoArea GreaterTorontoArea = new C19M.D.Gumel2006.Classes.GreaterTorontoArea();

            // Context
            C19M.M.C.A.Gumel2006.Interfaces.Contexts.IGumel2006_Context context = new C19M.M.C.A.Gumel2006.Classes.Contexts.Gumel2006_Context(
                GreaterTorontoArea.DiseaseInducedMortalityRate,
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                GreaterTorontoArea.DevelopmentClinicalSymptomsRate,
                GreaterTorontoArea.EffectiveContactRate,
                GreaterTorontoArea.RecoveryRate,
                GreaterTorontoArea.NaturalMortalityRate,
                GreaterTorontoArea.VaccinationCoverageRate,
                GreaterTorontoArea.RecruitmentRateSusceptibleHumans,
                GreaterTorontoArea.VaccineEfficacy);

            // Export
            C19M.M.C.A.Gumel2006.Interfaces.Exports.IDiseaseTransmission_Export export = new C19M.M.C.A.Gumel2006.Classes.Exports.DiseaseTransmission_Export(
                context);

            export.Solve();

            var dayCumulativeDiseaseInducedDeaths = export.DayCumulativeDiseaseInducedDeaths;

            foreach (var item in dayCumulativeDiseaseInducedDeaths)
            {
                System.Diagnostics.Debug.WriteLine(
                    item.Item2.Value.Value);
            }
        }
    }
}