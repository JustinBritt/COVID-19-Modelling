# COVID-19-Modelling

## Introduction

Over the past few decades, there have been several outbreaks of zoonotic diseases, including influenza, Ebola Virus Disease, SARS/SARS-CoV, MERS-CoV, and COVID-19/SARS-CoV-2. 
As shown in the Literature section, many researchers have already developed mathematical models that describe the spread of these diseases.
The goal of this project is to develop a user interface that can help public health officials and researchers use these models to make decisions on how to control the spread of these diseases.

## Literature

Paper                                                                                     | Virus / Disease                         | Sub-populations
------------ | ------------- | -------------
[Hethcote (2000)](https://epubs.siam.org/doi/abs/10.1137/s0036144500371907)                    | Several                                | SIR, SEIR, MSEIR
[Chowell *et al.* (2003)](https://www.sciencedirect.com/science/article/pii/S0022519303002285) | SARS-CoV                               | SEIJR
[Alexander *et al.* (2004)](https://epubs.siam.org/doi/abs/10.1137/030600370)                  | Influenza                              | SVIRS
[Gumel *et al.* (2004)](https://royalsocietypublishing.org/doi/10.1098/rspb.2004.2800)         | SARS-CoV                               | SEQIJR
[Arino *et al.* (2006)](https://royalsocietypublishing.org/doi/full/10.1098/rsif.2006.0112)    | Influenza                              | SLIAR, SLIAS<sub>T</sub>L<sub>T</sub>I<sub>T</sub>A<sub>T</sub>R
[Gumel *et al.* (2006)](https://www.aimspress.com/article/10.3934/mbe.2006.3.485)              | SARS-CoV                               | SVEIR
[McLeod *et al.* (2006)](http://www.aimspress.com/article/10.3934/mbe.2006.3.527)              | SARS-CoV                               | SEQIJR
[Ruan *et al.* (2006)](https://www.aimspress.com/article/10.3934/mbe.2006.3.205)               | SARS-CoV                               | SEIQR
[Yan and Zou (2008)](https://www.sciencedirect.com/science/article/pii/S0895717707001628)      | SARS-CoV                               | SEQIJR
[Safi *et al.* (2010)](http://www.aimsciences.org/article/doi/10.3934/dcdsb.2010.14.209)       | Communicable disease, such as SARS-CoV | SEIQHRS
[Lee *et al.* (2016)](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7094115/)                   | MERS-CoV                               | SEIJR
[Khan and Zaman (2018)](https://onlinelibrary.wiley.com/doi/full/10.1002/oca.2437)             | Infectious disease                     | SEIR
[Thäter *et al.* (2018)](https://www.aimsciences.org/article/doi/10.3934/mbe.2018022)          | Infectious disease                     | SEIR
[Tang *et al.* (2020)](https://www.mdpi.com/2077-0383/9/2/462)                                 | SARS-CoV-2                             | SEIAS<sub>q</sub>E<sub>q</sub>HR
### Projects

#### Data Projects

Data are provided in the Data namespace (C19M.D.*). [Release 4 (R4) of the Health Level 7 Fast Healthcare Interoperability Resources (HL7 FHIR)](https://hl7.org/fhir/R4/index.html) is used.

#### Models - Compartmental Models Projects

In projects in the Models - Compartmental Models - Approximate Solution Methods namespace (C19M.M.C.A.*), approximate solutions for compartmental models are obtained using the [ordinary differential equation (ODE) solvers in MathNet.Numerics.](https://numerics.mathdotnet.com/api/MathNet.Numerics.OdeSolvers/)  Unless otherwise noted, these projects are programmed in C# and use the .NET Framework 4.8.

In projects in the Models - Compartmental Models - System Dynamics namespace (C19M.M.C.SD.*), AnyLogic is used to simulate compartmental models.

Paper                                                                                    | Data Folder      | Approximate Solution Methods Folder | System Dynamics Folder
------------ | ------------- | ------------- | ------------- 
[Gumel *et al.* (2004)](https://royalsocietypublishing.org/doi/10.1098/rspb.2004.2800)   | C19M.D.Gumel2004 | C19M.M.C.A.Gumel2004       |  C19M.M.C.SD.Gumel2004           
[Gumel *et al.* (2006)](https://www.aimspress.com/article/10.3934/mbe.2006.3.485)        | C19M.D.Gumel2006 | C19M.M.C.A.Gumel2006       |          
[Safi *et al.* (2010)](http://www.aimsciences.org/article/doi/10.3934/dcdsb.2010.14.209) | C19M.D.Safi2010  | C19M.M.C.A.Safi2010        |     
[Lee *et al.* (2016)](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7094115/)             | C19M.D.Lee2016   | C19M.M.C.A.Lee2016         |        

## References

[Alexander, M. E., Bowman, C., Moghadas, S. M., Summers, R., Gumel, A. B., & Sahai, B. M. (2004). A vaccination model for transmission dynamics of influenza. SIAM Journal on Applied Dynamical Systems, 3(4), 503-524.](https://epubs.siam.org/doi/abs/10.1137/030600370)

[Arino, J., Brauer, F., van den Driessche, P., Watmough, J., & Wu, J. (2006). Simple models for containment of a pandemic. Journal of the Royal Society Interface, 3(8), 453-457.](https://royalsocietypublishing.org/doi/full/10.1098/rsif.2006.0112)

[Chowell, G., Fenimore, P. W., Castillo-Garsow, M. A., & Castillo-Chavez, C. (2003). SARS outbreaks in Ontario, Hong Kong and Singapore: the role of diagnosis and isolation as a control mechanism. Journal of theoretical biology, 224(1), 1-8.](https://www.sciencedirect.com/science/article/pii/S0022519303002285)

[Gumel, A. B., Ruan, S., Day, T., Watmough, J., Brauer, F., Van den Driessche, P., ... & Wu, J. (2004). Modelling strategies for controlling SARS outbreaks. Proceedings of the Royal Society of London. Series B: Biological Sciences, 271(1554), 2223-2232.](https://royalsocietypublishing.org/doi/10.1098/rspb.2004.2800)

[Gumel, A. B., McCluskey, C. C., & Watmough, J. (2006). An SVEIR model for assessing potential impact of an imperfect anti-SARS vaccine.](https://www.aimspress.com/article/10.3934/mbe.2006.3.485) 

[Hethcote, H. W. (2000). The mathematics of infectious diseases. SIAM review, 42(4), 599-653.](https://epubs.siam.org/doi/abs/10.1137/s0036144500371907)

[Khan, A., & Zaman, G. (2018). Optimal control strategy of SEIR endemic model with continuous age‐structure in the exposed and infectious classes. Optimal Control Applications and Methods, 39(5), 1716-1727.](https://onlinelibrary.wiley.com/doi/full/10.1002/oca.2437) 

[Lee, J., Chowell, G., & Jung, E. (2016). A dynamic compartmental model for the Middle East respiratory syndrome outbreak in the Republic of Korea: a retrospective analysis on control interventions and superspreading events. Journal of theoretical biology, 408, 118-126.](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7094115/) 

[McLeod, R. G., Brewster, J. F., Gumel, A. B., & Slonowsky, D. A. (2006). Sensitivity and uncertainty analyses for a SARS model with time-varying inputs and outputs. Mathematical Biosciences & Engineering, 3(3), 527.](http://www.aimspress.com/article/10.3934/mbe.2006.3.527) 

[Ruan, S., Wang, W., & Levin, S. A. (2006). The effect of global travel on the spread of SARS. Mathematical Biosciences & Engineering, 3(1), 205.](https://www.aimspress.com/article/10.3934/mbe.2006.3.205)

[Safi, M. A., & Gumel, A. B. (2010). Global asymptotic dynamics of a model for quarantine and isolation. Discrete & Continuous Dynamical Systems-B, 14(1), 209.](http://www.aimsciences.org/article/doi/10.3934/dcdsb.2010.14.209)

[Tang, B., Wang, X., Li, Q., Bragazzi, N. L., Tang, S., Xiao, Y., & Wu, J. (2020). Estimation of the transmission risk of the 2019-nCoV and its implication for public health interventions. Journal of Clinical Medicine, 9(2), 462.](https://www.mdpi.com/2077-0383/9/2/462)    

[Thäter, M., Chudej, K., & Pesch, H. J. (2018). Optimal vaccination strategies for an SEIR model of infectious diseases with logistic growth. Mathematical Biosciences & Engineering, 15(2), 485.](https://www.aimsciences.org/article/doi/10.3934/mbe.2018022) 

[Yan, X., & Zou, Y. (2008). Optimal and sub-optimal quarantine and isolation control in SARS epidemics. Mathematical and Computer Modelling, 47(1-2), 235-245.](https://www.sciencedirect.com/science/article/pii/S0895717707001628)