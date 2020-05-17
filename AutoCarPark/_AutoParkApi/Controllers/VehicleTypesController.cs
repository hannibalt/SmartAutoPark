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
    public class VehicleTypessController : ControllerBase
    {
        IVehicleTypeService _vehicleTypeService;
        public VehicleTypessController(IVehicleTypeService vehicleTypeService)
        {
            _vehicleTypeService = vehicleTypeService;
        }
        
        //  [Route("GetAirports")]
        [HttpGet]
        public List<VehicleTypes> GetVehicleTypes()
        {
            return _vehicleTypeService.GetAll();
        }
        //    [Route("AddAirports")]
        [HttpPost]
        public void POST(VehicleTypes VehicleTypes)
        {
            _vehicleTypeService.Add(VehicleTypes);
        }
        // DELETE: api/Deleteairports
        //    [Route("Deleteairports")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var vehicletype = _vehicleTypeService.GetVehicleTypesById(id);
            _vehicleTypeService.Delete(vehicletype);
        }
        // PUT: api/CountryPut
        //     [Route("EditCountry")]
        [HttpPut("{id}")]
        public void PUT(VehicleTypes VehicleTypes)
        {
           
            _vehicleTypeService.Update(VehicleTypes);


            
        }

        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public VehicleTypes GetVehicleTypes(int id)
        {
            return _vehicleTypeService.GetVehicleTypesById(id);
        }
    }
}