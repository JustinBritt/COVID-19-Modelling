﻿namespace C19M.UI.Imports.Gumel2004
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Web;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.D.Gumel2004.Interfaces;

    public sealed class Beijing
    {
        // Constructor
        public Beijing()
        {
            C19M.D.Gumel2004.Interfaces.IBeijing Beijing = new C19M.D.Gumel2004.Classes.Beijing();

            // Contexts
            C19M.M.C.A.Gumel2004.Interfaces.Contexts.IGumel2004_Context Beijing_Context = new C19M.M.C.A.Gumel2004.Classes.Contexts.Gumel2004_Context(
                Beijing.EndDate,
                Beijing.NumberDaysAfterStartDate,
                Beijing.StartDate,
                Beijing.DiseaseInducedDeathRateSymptomaticIndividuals,
                Beijing.DiseaseInducedDeathRateIsolatedIndividuals,
                Beijing.InitialValueAsymptomaticIndividuals,
                Beijing.InitialValueSymptomaticIndividuals,
                Beijing.InitialValueIsolatedIndividuals,
                Beijing.RecruitmentRateAsymptomaticIndividuals,
                Beijing.InitialValueQuarantinedIndividuals,
                Beijing.InitialValueRecoveredIndividuals,
                null, // GTA.BasicReproductionNumber,
                null, // GTA.ControlReproductionNumber,
                Beijing.InitialValueSusceptibleIndividuals,
                Beijing.BasicTransmissionCoefficient,
                Beijing.QuarantineRateAsymptomaticIndividuals,
                Beijing.IsolationRateSymptomaticIndividuals,
                Beijing.TransmissionCoefficientModificationFactorAsymptomaticIndividuals,
                Beijing.TransmissionCoefficientModificationFactorIsolatedIndividuals,
                Beijing.TransmissionCoefficientModificationFactorQuarantinedIndividuals,
                Beijing.DevelopmentClinicalSymptomsRateAsymptomaticIndividuals,
                Beijing.DevelopmentClinicalSymptomsRateQuarantinedIndividuals,
                Beijing.NaturalDeathRate,
                Beijing.NetInflowRateSusceptibleIndividuals,
                Beijing.RecoveryRateSymptomaticIndividuals,
                Beijing.RecoveryRateIsolatedIndividuals);

            // Exports
            C19M.M.C.A.Gumel2004.Interfaces.Exports.IGumel2004_Export Beijing_Export = new C19M.M.C.A.Gumel2004.Classes.Exports.Gumel2004_Export(
                Beijing_Context);

            Beijing_Export.Solve();
        }

        private C19M.D.Gumel2004.Interfaces.IBeijing Data => new C19M.D.Gumel2004.Classes.Beijing();
    }
}