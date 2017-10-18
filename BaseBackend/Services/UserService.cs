using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using BaseBackend.Repositories;
using System.Web;
using BaseBackend.DbContexts;

namespace BaseBackend.Services
{
    public class UserService : IUserPasswordStore<tblUser, int>, IUserEmailStore<tblUser, int>,
        IUserRoleStore<tblUser, int>
    {
        public void Dispose()
        {
        }

        private readonly BaseDbContext _dbContext = BaseDbContext.Create();

        TblUserRepository UserRepo => new TblUserRepository(_dbContext);
        TblRoleRepository RoleRepo => new TblRoleRepository(_dbContext);

        public async Task AddToRoleAsync(tblUser user, string roleName)
        {
            var role = await Task.Run(() => RoleRepo.FindAsync(x => x.Name == roleName));
            await Task.Run(() => UserRepo.AddToRole(user, role));
        }

        public async Task CreateAsync(tblUser user)
        {
            await Task.Run(() => UserRepo.Insert(user));
        }

        public async Task DeleteAsync(tblUser user)
        {
            await Task.Run(() => UserRepo.Delete(user));
        }

        public async Task<tblUser> FindByEmailAsync(string email)
        {
            return await Task.Run(() => UserRepo.FindAsync(x => x.UserName == email));
        }

        public async Task<tblUser> FindByIdAsync(int userId)
        {
            return await Task.Run(() => UserRepo.FindAsync(x => x.UserId == userId));
        }

        public async Task<tblUser> FindByNameAsync(string userName)
        {
            return await Task.Run(() => UserRepo.FindAsync(x => x.UserName == userName));
        }

        public async Task<string> GetEmailAsync(tblUser user)
        {
            return await Task.FromResult(user.UserName);
        }

        public Task<bool> GetEmailConfirmedAsync(tblUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetPasswordHashAsync(tblUser user)
        {
            return await Task.FromResult(user.Password);
        }

        public Task<IList<string>> GetRolesAsync(tblUser user)
        {
            return Task.Run(() => UserRepo.GetRoles(user.UserId));
        }

        public Task<bool> HasPasswordAsync(tblUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsInRoleAsync(tblUser user, string roleName)
        {
            IList<string> roles = await GetRolesAsync(user);
            return roles.Contains(roleName);
        }

        public Task RemoveFromRoleAsync(tblUser user, string roleName)
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

        public async Task UpdateAsync(tblUser user)
        {
            await Task.Run(() => UserRepo.Update(user));
        }
    }

}