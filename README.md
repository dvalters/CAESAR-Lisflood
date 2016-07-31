# CAESAR-lisflood

This is a modified version of the Caesar-Lisflood model I use during my phd work: linking atmospheric dynamics and landscape evolution models. It is based on version 1.8f

This version has extra routines for bedrock erosion based on shear stress calculated directly from the hydrodynamic shallow water flow model in CAESAR-Lisflood. 

The bedrock erosion is based on the simple excess shear stress model (Howard and Kerby, 1983). Note, that in this implementation the user can set the Pb exponents, as well as the bedrock erodibility coefficien, Kb, and the threshold shear stress for bedrock incision. 

The original version of [CAESAR-Lislfood can be found here](https://sourceforge.net/projects/caesar-lisflood/). It has since been modified beyond version 1.8f.



