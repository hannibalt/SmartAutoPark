using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace _Business.Concrete
{
    public class UsersManager : IUsersService
    {
        private IUsersDal _usersdal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersdal = usersDal;
        }
        public void Add(Users users)
        {
            _usersdal.Add(users);
        }

        public void Delete(Users users)
        {
            _usersdal.Delete(users);
        }

        public List<Users> GetAll()
        {
            return _usersdal.GetList();
        }

        public Users GetByCarPlate(string id)
        {
            return _usersdal.Get(l => l.UseCarPlate.ToLower().Contains(id.ToLower()));

        }

        public List<Users> GetById(int userid)
        {
            return _usersdal.GetList(l => l.UseId == userid);
        }

        public Users GetUsersById(int id)
        {
            var users = _usersdal.Get(c => c.UseId == id);
            return users;
        }

        public Users IsUserActive(string nameplate)
        {
            var result = _usersdal.Get(c => (c.UseCarPlate == nameplate) && c.UseActive == true);
            return result;
        }


        public void Update(Users users)
        {
            _usersdal.Update(users);
        }
    }
}
