using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using BaseBackend.Repositories;
using System.Web;

namespace BaseBackend.Services
{
    public class UserService : IUserPasswordStore<tblUser, int>, IUserEmailStore<tblUser, int>,
        IUserLoginStore<tblUser, int>, IUserRoleStore<tblUser, int>
    {
        public void Dispose()
        {
        }

        TblUserRepository _repo => new TblUserRepository();

        public Task AddLoginAsync(tblUser user, UserLoginInfo login)
        {
            throw new NotImplementedException();
        }

        public Task AddToRoleAsync(tblUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(tblUser user)
        {
            await Task.Run(() => _repo.InsertAsync(user));
        }

        public Task DeleteAsync(tblUser user)
        {
            throw new NotImplementedException();
        }

        public Task<tblUser> FindAsync(UserLoginInfo login)
        {
            throw new NotImplementedException();
        }

        public async Task<tblUser> FindByEmailAsync(string email)
        {
            return await Task.Run(() => _repo.FindByEmailAsync(email));
        }

        public async Task<tblUser> FindByIdAsync(int userId)
        {
            return await Task.Run(() => _repo.FindByIdAsync(userId));
        }

        public async Task<tblUser> FindByNameAsync(string userName)
        {
            return await Task.Run(() => _repo.FindByNameAsync(userName));
        }

        public async Task<string> GetEmailAsync(tblUser user)
        {
            return await Task.FromResult(user.UserName);
        }

        public Task<bool> GetEmailConfirmedAsync(tblUser user)
        {
            throw new NotImplementedException();
        }

        public Task<IList<UserLoginInfo>> GetLoginsAsync(tblUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetPasswordHashAsync(tblUser user)
        {
            return await Task.FromResult(user.Password);
        }

        public Task<IList<string>> GetRolesAsync(tblUser user)
        {
            // TODO: Extend this function if you want to use roles

            IList<string> roles = new List<string>();
            roles.Add("Role1");

            return Task.FromResult(roles);
        }

        public Task<bool> HasPasswordAsync(tblUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(tblUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromRoleAsync(tblUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLoginAsync(tblUser user, UserLoginInfo login)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailAsync(tblUser user, string email)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailConfirmedAsync(tblUser user, bool confirmed)
        {
            throw new NotImplementedException();
        }

        public async Task SetPasswordHashAsync(tblUser user, string passwordHash)
        {
            await Task.Run(() => user.Password = passwordHash);
        }

        public Task UpdateAsync(tblUser user)
        {
            throw new NotImplementedException();
        }
    }

}