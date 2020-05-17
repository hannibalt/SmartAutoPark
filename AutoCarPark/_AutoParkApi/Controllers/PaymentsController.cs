using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _AutoParkData.Models;
using Microsoft.EntityFrameworkCore;
using _Business.Abstract;

namespace _AutoParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        IPaymentsService _paymentsService;
        public PaymentsController(IPaymentsService paymentsService)
        {
            _paymentsService = paymentsService;
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
    }
}