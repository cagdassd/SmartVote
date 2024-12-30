using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.DbContexts;
using DataAccessLayer.GenericStructure;
using Entities.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, VotingDbContext>, IUserDal
    {
    }
}
