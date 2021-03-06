﻿namespace C19M.M.C.A.Gumel2006.Tests
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
            C19M.D.Gumel2006.Interfaces.ITable1 Table1 = new C19M.D.Gumel2006.Classes.Table1();

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
                Table1.DiseaseInducedMortalityRate,
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(10), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(4000000), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                Table1.DevelopmentClinicalSymptomsRate,
                Table1.EffectiveContactRate,
                Table1.RecoveryRate,
                Table1.NaturalMortalityRate,
                Table1.VaccinationCoverageRate,
                Table1.RecruitmentRateSusceptibleHumans,
                Table1.VaccineEfficacy);

            // Export
            C19M.M.C.A.Gumel2006.Interfaces.Exports.IDiseaseTransmission_Export export = new C19M.M.C.A.Gumel2006.Classes.Exports.DiseaseTransmission_Export(
                context);

            export.Solve();

            var I = export.DayInfectedIndividuals;

            var S = export.DaySusceptibleIndividuals;

            var dayCumulativeDiseaseInducedDeaths = export.DayCumulativeDiseaseInducedDeaths;

            foreach (var item in I)
            {
                System.Diagnostics.Debug.WriteLine(
                    item.Item2.Value.Value);
            }
        }
    }
}