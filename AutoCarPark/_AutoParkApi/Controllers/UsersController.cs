using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _AutoParkData.Models;
using _Business.Abstract;

namespace _AutoParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUsersService _usersservice;
        public UsersController(IUsersService usersService)
        {
            _usersservice = usersService;
        }

        //  [Route("GetAirports")]
        [HttpGet]
        public List<Users> GetUsers()
        {
            return _usersservice.GetAll();
        }
        //    [Route("AddAirports")]
        [HttpPost]
        public void POST(Users users)
        {
            _usersservice.Add(users);
        }
        // DELETE: api/Deleteairports
        //    [Route("Deleteairports")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var vehicletype = _usersservice.GetUsersById(id);
            _usersservice.Delete(vehicletype);
        }
        // PUT: api/CountryPut
        //     [Route("EditCountry")]
        [HttpPut("{id}")]
        public void PUT(Users users)
        {

            _usersservice.Update(users);



        }

        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public Users GetUsers(int id)
        {
            return _usersservice.GetUsersById(id);
        }
    }
}