# backend-template
Boiler-template for Backend & WebApi w/ token-based authentication
------------------------------------------------------------------

This template is a lightweight-solution based on Owin with the Identity-framework using a custom datastorage, and makes use of bearer-tokens for authorizing users. Anything beyond this you will have to implement on your own. I've excluded external login

Initial steps to get started:

*tblUser:* UserId(int), UserName(nvarchar(50)), Password(nvarchar(500)), Created(datetime), Modified(datetime)

1. Select the solution and press 'Restore Nuget Packages'
2. Create a new database or implement the above table in an existing database (see requirements for tblUser above)
3. Add a new model of your database to the BaseBackend project, in the BaseBackend namespace. Default names for this model are BaseModel and BaseEntities for the context.
4. Copy the generated connectionstring from App.config to the Web.config in BaseApi
5. Start the Api
