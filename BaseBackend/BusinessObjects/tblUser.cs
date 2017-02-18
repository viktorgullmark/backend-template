using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using BaseBackend.Interfaces;

namespace BaseBackend
{
    public partial class tblUser : IUser<int>, IBaseEntity
    {
        public int Id => UserId;

        // Any custom mappings here

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<tblUser, int> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
