using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.DbContexts;
using DataAccessLayer.GenericStructure;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfElectionDal : EfEntityRepositoryBase<Election, VotingDbContext>, IElectionDal
    {
    }
}
