# backend-template
Boiler-template for Backend & WebApi w/ token-based authentication
------------------------------------------------------------------

This template is a lightweight-solution based on Owin with the Identity-framework using a custom datastorage, and makes use of bearer-tokens for authorizing users with a basic role-management system. Anything beyond this you will have to implement on your own. I've excluded external login

Initial steps to get started:

1. Create a new database, and apply the sql-script contained in BaseBackend/Scripts.
2. Tweak your connection-strings to your newly created database
3. Run the project!
