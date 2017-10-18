using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBackend.DbContexts;
using BaseBackend.Interfaces;
using BaseBackend.Services;

namespace BaseBackend.Repositories
{
    public class TblUserRepository : GenericRepository<BaseDbContext, tblUser>
    {
        public TblUserRepository()
        {   
        }

        public TblUserRepository(BaseDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IList<string>> GetRoles(int userId)
        {
            return await DbContext.tblRole.Where(x => x.tblUser.Any(z => z.UserId == userId)).Select(y => y.Name).ToListAsync();
        }

        public async Task<tblUser> AddToRole(tblUser user, tblRole role)
        {
            user.tblRole.Add(role);
            return await Update(user);
        }
    }
}
