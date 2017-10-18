using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using BaseApi.Models;
using BaseApi.Providers;
using BaseBackend;
using BaseBackend.DbContexts;
using BaseBackend.Enums;
using BaseBackend.Repositories;
using BaseBackend.Services;

namespace BaseApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/Role")]
    public class RoleController : ApiController
    {
        private readonly RoleService _roleService = new RoleService();

        public RoleController()
        {
        }

        [Route("IsAdmin")]
        [HttpGet]
        public async Task<bool> IsAdmin()
        {
            var role = await _roleService.GetRoleById((int)RoleEnum.Admin);

            return ClaimsPrincipal.Current.IsInRole(role.Name);
        }

        [Route("IsMember")]
        [HttpGet]
        public async Task<bool> IsMember()
        {
            var role = await _roleService.GetRoleById((int)RoleEnum.Member);

            return ClaimsPrincipal.Current.IsInRole(role.Name);
        }
    }
}
