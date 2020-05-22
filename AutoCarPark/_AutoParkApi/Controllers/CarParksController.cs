using _AutoParkData.Models;
using _Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _AutoParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarParksController : ControllerBase
    {
        ICarParksService _carparksservice;
        public CarParksController(ICarParksService carParksService)
        {
            _carparksservice = carParksService;
        }

        //  [Route("GetAirports")]
        [HttpGet]
        public List<CarParks> GetCarParks()
        {
            return _carparksservice.GetAll();
        }
        //    [Route("AddAirports")]
        [HttpPost]
        public void POST(CarParks carParks)
        {
            _carparksservice.Add(carParks);
        }
        // DELETE: api/Deleteairports
        //    [Route("Deleteairports")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var vehicletype = _carparksservice.GetCarParks(id);
            _carparksservice.Delete(vehicletype);
        }
        // PUT: api/CountryPut
        //     [Route("EditCountry")]
        [HttpPut("{id}")]
        public void PUT(CarParks carParks)
        {

            _carparksservice.Update(carParks);



        }

        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public CarParks GetCarParks(int id)
        {
            return _carparksservice.GetCarParks(id);
        }
    }
}