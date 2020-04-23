# COVID-19-Modelling

## Introduction

Over the past 25 years, there have been several outbreaks of zoonotic diseases, including influenza, Ebola, SARS/SARS-CoV, MERS-CoV, and COVID-19/SARS-CoV-2. 
As shown in the Literature section, many researchers have already developed mathematical models that describe the spread of these diseases.
The goal of this project is to develop a user interface that can help public health officials and researchers use these models to make decisions on how to control the spread of these diseases.

## Literature

Paper                                                                                    | Virus / Disease   | Sub-populations
------------ | ------------- | -------------
[Gumel *et al.* (2004)](https://royalsocietypublishing.org/doi/10.1098/rspb.2004.2800)   | SARS-CoV                               | Susceptible, Asymptomatic, Quarantined, Symptomatic, Isolated, and Recovered
[Gumel *et al.* (2006)](https://www.aimspress.com/article/10.3934/mbe.2006.3.485)        | SARS-CoV                               | Susceptible, Vaccinated, Latent, Infected, and Treated
[Safi *et al.* (2010)](http://www.aimsciences.org/article/doi/10.3934/dcdsb.2010.14.209) | Communicable disease, such as SARS-CoV |
[Lee *et al.* (2016)](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7094115/)             | MERS-CoV                               |
[Khan *et al.* (2018)](https://onlinelibrary.wiley.com/doi/full/10.1002/oca.2437)   | |

### Projects

#### Data Projects

Data are provided in the Data namespace (C19M.D.*). [Release 4 (R4) of the Health Level 7 Fast Healthcare Interoperability Resources (HL7 FHIR)](https://hl7.org/fhir/R4/index.html) is used.

#### Models - Compartmental Models Projects

In projects in the Models - Compartmental Models - Approximate Solution Methods namespace (C19M.M.CM.A.*), approximate solutions for compartmental models are obtained using the [ordinary differential equation (ODE) solvers in MathNet.Numerics.](https://numerics.mathdotnet.com/api/MathNet.Numerics.OdeSolvers/)  Unless otherwise noted, these projects are programmed in C# and use the .NET Framework 4.8.

In projects in the Models - Compartmental Models - System Dynamics namespace (C19M.M.CM.SD.*), AnyLogic is used to simulate compartmental models.

Paper                                                                                    | Data Folder      | Approximate Solution Methods Folder | System Dynamics Folder
------------ | ------------- | ------------- | ------------- 
[Gumel *et al.* (2004)](https://royalsocietypublishing.org/doi/10.1098/rspb.2004.2800)   | C19M.D.Gumel2004 | C19M.M.C.A.Gumel2004       |              
[Gumel *et al.* (2006)](https://www.aimspress.com/article/10.3934/mbe.2006.3.485)        | C19M.D.Gumel2006 | C19M.M.C.A.Gumel2006       |          
[Safi *et al.* (2010)](http://www.aimsciences.org/article/doi/10.3934/dcdsb.2010.14.209) | C19M.D.Safi2010  | C19M.M.C.A.Safi2010        |     
[Lee *et al.* (2016)](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7094115/)             | C19M.D.Lee2016   | C19M.M.C.A.Lee2016         |        
[Khan *et al.* (2018)](https://onlinelibrary.wiley.com/doi/full/10.1002/oca.2437)        | | |

## References

Gumel, A. B., Ruan, S., Day, T., Watmough, J., Brauer, F., Van den Driessche, P., ... & Wu, J. (2004). Modelling strategies for controlling SARS outbreaks. Proceedings of the Royal Society of London. Series B: Biological Sciences, 271(1554), 2223-2232.

Gumel, A. B., McCluskey, C. C., & Watmough, J. (2006). An SVEIR model for assessing potential impact of an imperfect anti-SARS vaccine.

Khan, A., & Zaman, G. (2018). Optimal control strategy of SEIR endemic model with continuous age‐structure in the exposed and infectious classes. Optimal Control Applications and Methods, 39(5), 1716-1727.

Safi, M. A., & Gumel, A. B. (2010). Global asymptotic dynamics of a model for quarantine and isolation. Discrete & Continuous Dynamical Systems-B, 14(1), 209.

Lee, J., Chowell, G., & Jung, E. (2016). A dynamic compartmental model for the Middle East respiratory syndrome outbreak in the Republic of Korea: a retrospective analysis on control interventions and superspreading events. Journal of theoretical biology, 408, 118-126.