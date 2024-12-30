using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task Add(User entity)
        {
            await _userDal.Add(entity);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userDal.GetAll();
        }
    }
}
