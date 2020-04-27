namespace C19M.M.C.A.Safi2010.Interfaces.Results.DayHospitalizedIndividuals
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Hl7
    using Hl7.Fhir.Model;

    using C19M.M.C.A.Safi2010.Interfaces.ResultElements.DayHospitalizedIndividuals;

    internal interface IH
    {
        ImmutableList<IH_ResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            FhirDateTime t_IndexElement);
    }
}