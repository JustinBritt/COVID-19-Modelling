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

            // Use StartDate, EndDate,and NumberDaysAfterStartDate from Gumel et al. (2004)
            FhirDateTime startDate = new FhirDateTime(new DateTimeOffset(new DateTime(2003, 2, 23)));

            FhirDateTime endDate = new FhirDateTime(new DateTimeOffset(new DateTime(2003, 9, 1)));

            Func<FhirDateTime, PositiveInt> numberDaysAfterStartDate =
            (x) =>
            {
                if (x.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date >= startDate.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date)
                {
                    return new PositiveInt((int)Math.Abs(Math.Round((x.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date - startDate.ToPartialDateTime().Value.ToUniversalTime().DateTime.Date).TotalDays)));
                }
                else
                {
                    return new PositiveInt(0);
                }
            };

            // Context
            C19M.M.C.A.Gumel2006.Interfaces.Contexts.IGumel2006_Context context = new C19M.M.C.A.Gumel2006.Classes.Contexts.Gumel2006_Context(
                endDate,
                numberDaysAfterStartDate,
                startDate,
                GreaterTorontoArea.DiseaseInducedMortalityRate,
                new Hl7.Fhir.Model.FhirDecimal(6), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(1), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(4000000), // TODO: Change
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

            C19M.M.C.A.Gumel2006.Interfaces.Solutions.IDiseaseTransmission_Solution solution = new C19M.M.C.A.Gumel2006.Classes.Solutions.DiseaseTransmission_Solution();

            solution.Solve(
                context);

            var I = solution.I;

            var dayCumulativeDiseaseInducedDeaths = solution.DayCumulativeDiseaseInducedDeaths;

            foreach (var item in dayCumulativeDiseaseInducedDeaths.Value)
            {
                System.Diagnostics.Debug.WriteLine(
                    item.Value.Value.Value);
            }
        }
    }
}