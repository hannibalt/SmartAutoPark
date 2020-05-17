using _AutoParkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Abstract
{
   public interface IUsersService
    {
        List<Users> GetAll();
        List<Users> GetById(int userid);

        Users GetUsersById(int id);
        void Add(Users users);
        void Update(Users users);
        void Delete(Users users);
    }
}
