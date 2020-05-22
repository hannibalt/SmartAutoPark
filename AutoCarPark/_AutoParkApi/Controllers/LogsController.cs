using _AutoParkData.Models;
using _Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _AutoParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        ILogsService _logservice;
        public LogsController(ILogsService logsService)
        {
            _logservice = logsService;
        }

        //  [Route("GetAirports")]
        [HttpGet]
        public List<Logs> GetLogsAll()
        {
            return _logservice.GetAll();
        }
        //    [Route("AddAirports")]
        [HttpPost]
        public void POST(Logs logs)
        {
            _logservice.Add(logs);
        }
        // DELETE: api/Deleteairports
        //    [Route("Deleteairports")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var logs = _logservice.GetLogsById(id);
            _logservice.Delete(logs);
        }
        // PUT: api/CountryPut
        //     [Route("EditCountry")]
        [HttpPut("{id}")]
        public void PUT(Logs logs)
        {
            _logservice.Update(logs);
        }

        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public Logs GetLogs(int id)
        {
            return _logservice.GetLogsById(id);
        }

    }
}