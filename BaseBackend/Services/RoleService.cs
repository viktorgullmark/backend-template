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
    public class RoleService
    {
        public void Dispose()
        {
        }

        private readonly BaseDbContext _dbContext = BaseDbContext.Create();

        TblRoleRepository RoleRepo => new TblRoleRepository(_dbContext);

        public async Task<tblRole> GetRoleById(int roleId)
        {
            return await RoleRepo.FindAsync(x => x.RoleId == roleId);
        }
    }
}