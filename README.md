# BackendTemplate
Boiler-template for Backend & WebApi w/ token-based authentication
------------------------------------------------------------------

This template is a lightweight-solution based on Owin with the Identity-framework using a custom datastorage, and makes use of bearer-tokens for authorizing users. Anything beyond this you will have to implement on your own.

Initial steps to get started:

1. Add a new model of your database to the BaseBackend project (see requirements for tblUser below)
2. Copy the generated connectionstring from App.config to the Web.config in BaseApi
3. Start the Api

tblUser:

  UserId(int)
  UserName(nvarchar(50))
  Password(nvarchar(500))
  Created(datetime)
  Modified(datetime)
