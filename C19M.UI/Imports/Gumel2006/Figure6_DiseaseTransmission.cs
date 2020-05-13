namespace C19M.UI.Imports.Gumel2006
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.D.Gumel2006.Interfaces;

    public sealed class Figure6_DiseaseTransmission
    {
        // Constructor
        public Figure6_DiseaseTransmission()
        {
            C19M.D.Gumel2006.Interfaces.IFigure6 Figure6 = new C19M.D.Gumel2006.Classes.Figure6();

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
                Figure6.DiseaseInducedMortalityRate,
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(10), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(4000000), // TODO: Change
                new Hl7.Fhir.Model.FhirDecimal(0), // TODO: Change
                Figure6.DevelopmentClinicalSymptomsRate,
                Figure6.EffectiveContactRate,
                Figure6.RecoveryRate,
                Figure6.NaturalMortalityRate,
                Figure6.VaccinationCoverageRate,
                Figure6.RecruitmentRateSusceptibleHumans,
                Figure6.VaccineEfficacy);

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