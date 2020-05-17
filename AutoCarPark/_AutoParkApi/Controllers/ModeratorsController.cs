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
    public class ModeratorsController : ControllerBase
    {

        IModeratorsService _moderatorsservice;
        public ModeratorsController(IModeratorsService moderatorsService)
        {
            _moderatorsservice = moderatorsService;
        }

        //  [Route("GetAirports")]
        [HttpGet]
        public List<Moderators> GetModeratorsAll()
        {
            return _moderatorsservice.GetAll();
        }
        //    [Route("AddAirports")]
        [HttpPost]
        public void POST(Moderators mod)
        {
            _moderatorsservice.Add(mod);
        }
        // DELETE: api/Deleteairports
        //    [Route("Deleteairports")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var mod = _moderatorsservice.GetModerators(id);
            _moderatorsservice.Delete(mod);
        }
        // PUT: api/CountryPut
        //     [Route("EditCountry")]
        [HttpPut("{id}")]
        public void PUT(Moderators mod)
        {
            _moderatorsservice.Update(mod);
        }

        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public Moderators GetModerator(int id)
        {
            return _moderatorsservice.GetModerators(id);
        }
    }
}