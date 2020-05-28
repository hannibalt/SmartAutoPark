using _AutoParkData.Models;
using System.Collections.Generic;

namespace _Business.Abstract
{
    public interface IUsersService
    {
        List<Users> GetAll();
        List<Users> GetById(int userid);

        Users GetUsersById(int id);
        Users GetByCarPlate(string id);
        Users IsUserActive(string nameplate);

        void Add(Users users);
        void Update(Users users);
        void Delete(Users users);
    }
}
