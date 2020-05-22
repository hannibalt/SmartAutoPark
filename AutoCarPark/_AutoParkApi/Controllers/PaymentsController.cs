using _AutoParkData.Models;
using _Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _AutoParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        IPaymentsService _paymentsService;
        ILogsService _logservice;
        public PaymentsController(IPaymentsService paymentsService, ILogsService logsService)
        {
            _paymentsService = paymentsService;
            _logservice = logsService;
        }

        //  [Route("GetAirports")]
        [HttpGet]
        public List<Payments> GetPaymentsAll()
        {
            return _paymentsService.GetAll();
        }
        //    [Route("AddAirports")]
        [HttpPost]
        public void POST(Payments payments)
        {
            _paymentsService.Add(payments);
        }
        // DELETE: api/Deleteairports
        //    [Route("Deleteairports")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var payments = _paymentsService.GetPayments(id);
            _paymentsService.Delete(payments);
        }
        // PUT: api/CountryPut
        //     [Route("EditCountry")]
        [HttpPut("{id}")]
        public void PUT(Payments pay)
        {
            _paymentsService.Update(pay);
        }

        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public Payments GetPayment(int id)
        {
            return _paymentsService.GetPayments(id);
        }
        [HttpPost("logs")]
        public bool GetPayments(Logs logs)
        {
            var result = _paymentsService.GetPlateFromPaym(logs.SubPlate);
            if (result == true)
            {
                _logservice.Add(logs);
            }

            return result;
        }


    }
}