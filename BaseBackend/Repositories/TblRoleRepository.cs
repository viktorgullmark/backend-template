using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBackend.DbContexts;

namespace BaseBackend.Repositories
{
    public class TblRoleRepository : GenericRepository<BaseDbContext, tblRole>
    {
        public TblRoleRepository()
        {
        }

        public TblRoleRepository(BaseDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
