# BackendTemplate
Boiler-template for Backend & WebApi w/ token-based authentication
------------------------------------------------------------------

This template is based on Owin with the Identity-framework using a custom datastorage, and makes use of bearer-tokens for authorizing users. Anything beyond this you will have to implement on your own.

This is a lightweight implementation, only containing the required functions to register users and hand out tokens. In this solution I've included a sample-model based on my own database, mainly to display how it can be used as an example. Just replace the model with one from your own database (change connectionstrings accordingly) and the Api should be ready for use.
