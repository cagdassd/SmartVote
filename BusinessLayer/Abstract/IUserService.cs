using Entities.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        public Task<List<User>> GetUsers();
        public Task Add(User entity);
    }
}
