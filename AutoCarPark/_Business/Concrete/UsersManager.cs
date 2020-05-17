﻿using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

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

        public List<Users> GetById(int userid)
        {
            return _usersdal.GetList(l => l.UseId == userid);
        }

        public Users GetUsersById(int id)
        {
            var users = _usersdal.Get(c => c.UseId == id);
            return users;
        }

        public void Update(Users users)
        {
            _usersdal.Update(users);
        }
    }
}
