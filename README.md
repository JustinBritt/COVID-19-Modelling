# COVID-19-Modelling

## Introduction

TODO

## Literature

TODO

### Projects

#### Data (C19M.D.*) Projects

Data are provided in the Data (C19M.D.*) namespace. [Release 4 (R4) of the Health Level 7 Fast Healthcare Interoperability Resources (HL7 FHIR)](https://hl7.org/fhir/R4/index.html) is used.

#### Models - Compartmental Models - Approximate Solution Methods (C19M.M.CM.A.*) Projects

In these projects, approximate solutions for compartmental models are obtained using the [ordinary differential equation (ODE) solvers in MathNet.Numerics.](https://numerics.mathdotnet.com/api/MathNet.Numerics.OdeSolvers/) 

Unless otherwise noted, these projects are programmed in C# and use the .NET Framework 4.8.

Paper                                                                                    | Data Folder      | Approximate Solution Methods Folder | Virus
------------ | ------------- | ------------- | ------------- 
[Gumel *et al.* (2004)](https://royalsocietypublishing.org/doi/10.1098/rspb.2004.2800)   | C19M.D.Gumel2004 | C19M.M.C.A.Gumel2004                | SARS-CoV
[Gumel *et al.* (2006)](https://www.aimspress.com/article/10.3934/mbe.2006.3.485)        | C19M.D.Gumel2006 | C19M.M.C.A.Gumel2006                | SARS-CoV
[Safi *et al.* (2010)](http://www.aimsciences.org/article/doi/10.3934/dcdsb.2010.14.209) | C19M.D.Safi2010  | C19M.M.C.A.Safi2010                 | Communicable disease, such as SARS-CoV
[Lee *et al.* (2016)](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7094115/)             | C19M.D.Lee2016   | C19M.M.C.A.Lee2016                  | MERS-CoV 

#### Models - Compartmental Models - System Dynamics (C19M.M.CM.SD.*) Projects
Folder | Description
------------ | ------------

## References

Gumel, A. B., Ruan, S., Day, T., Watmough, J., Brauer, F., Van den Driessche, P., ... & Wu, J. (2004). Modelling strategies for controlling SARS outbreaks. Proceedings of the Royal Society of London. Series B: Biological Sciences, 271(1554), 2223-2232.

Gumel, A. B., McCluskey, C. C., & Watmough, J. (2006). An SVEIR model for assessing potential impact of an imperfect anti-SARS vaccine.

Safi, M. A., & Gumel, A. B. (2010). Global asymptotic dynamics of a model for quarantine and isolation. Discrete & Continuous Dynamical Systems-B, 14(1), 209.

Lee, J., Chowell, G., & Jung, E. (2016). A dynamic compartmental model for the Middle East respiratory syndrome outbreak in the Republic of Korea: a retrospective analysis on control interventions and superspreading events. Journal of theoretical biology, 408, 118-126.