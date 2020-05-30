using _AutoParkData.Models;
using _Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        [HttpPut]
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

        [HttpGet("GetUsersCarPlate/{carplate}")]
        public bool GetUsersCarPlate(string carplate)
        {
            var b = _usersservice.GetByCarPlate(carplate);
            if (b != null)
            {
                return true;
            }
            else
                return false;
        }
        [HttpGet("CarPlateForAll/{carplate}")]

        public Users GetUserFromPlate(string carplate)
        {
            return  _usersservice.GetByCarPlate(carplate);

        }

        [HttpGet("getusersactive/{carplate}")]

        public Users GetUserActive(string carplate)
        {
            var result = _usersservice.IsUserActive(carplate);
            return result;
        }
        [HttpGet("doactive/{carplate}")]

        public Users DoUserActive(string carplate)
        {
            var result = _usersservice.IsUserActive(carplate);
            return result;
        }
    }
}