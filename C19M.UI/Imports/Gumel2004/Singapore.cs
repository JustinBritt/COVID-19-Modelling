namespace C19M.UI.Imports.Gumel2004
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;

    using Hl7.Fhir.Model;

    using C19M.D.Gumel2004.Interfaces;

    public sealed class Singapore
    {
        public Singapore()
        {
            C19M.D.Gumel2004.Interfaces.ISingapore Singapore = new C19M.D.Gumel2004.Classes.Singapore();

            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context Singapore_Context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                Singapore.EndDate,
                Singapore.NumberDaysAfterStartDate,
                Singapore.StartDate,
                Singapore.DiseaseInducedDeathRateSymptomaticIndividuals,
                Singapore.DiseaseInducedDeathRateIsolatedIndividuals,
                Singapore.InitialValueAsymptomaticIndividuals,
                Singapore.InitialValueSymptomaticIndividuals,
                Singapore.InitialValueIsolatedIndividuals,
                Singapore.RecruitmentRateAsymptomaticIndividuals,
                Singapore.InitialValueQuarantinedIndividuals,
                Singapore.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                Singapore.InitialValueSusceptibleIndividuals,
                Singapore.BasicTransmissionCoefficient,
                Singapore.QuarantineRateAsymptomaticIndividuals,
                Singapore.IsolationRateSymptomaticIndividuals,
                Singapore.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                Singapore.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                Singapore.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                Singapore.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                Singapore.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                Singapore.NaturalDeathRate,
                Singapore.NetInflowRateSusceptibleIndividuals,
                Singapore.RecoveryRateSymptomaticIndividuals,
                Singapore.RecoveryRateIsolatedIndividuals);

            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export Singapore_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                Singapore_Context);

            Singapore_Export.Solve();

            this.DayCumulativeDiseaseInducedDeaths = Singapore_Export.DayCumulativeDiseaseInducedDeaths;

            this.DayAsymptomaticIndividuals = Singapore_Export.DayAsymptomaticIndividuals;

            this.DaySymptomaticIndividuals = Singapore_Export.DaySymptomaticIndividuals;

            this.DayIsolatedIndividuals = Singapore_Export.DayIsolatedIndividuals;

            this.DayQuarantinedIndividuals = Singapore_Export.DayQuarantinedIndividuals;

            this.DayRecoveredIndividuals = Singapore_Export.DayRecoveredIndividuals;

            this.DaySusceptibleIndividuals = Singapore_Export.DaySusceptibleIndividuals;
        }

        private C19M.D.Gumel2004.Interfaces.ISingapore Data => new C19M.D.Gumel2004.Classes.Singapore();

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayCumulativeDiseaseInducedDeaths { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayAsymptomaticIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySymptomaticIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayIsolatedIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayQuarantinedIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DayRecoveredIndividuals { get; set; }

        public ImmutableList<Tuple<FhirDateTime, FhirDecimal>> DaySusceptibleIndividuals { get; set; }
    }
}