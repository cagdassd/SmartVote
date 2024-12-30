using DataAccessLayer.GenericStructure;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
