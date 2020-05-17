﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using _AutoParkData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _Business.Abstract;

namespace _AutoParkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypeController : ControllerBase
    {
        IPaymentTypeService _paymentsTypeService;
        public PaymentTypeController(IPaymentTypeService paymentTypeService)
        {
            _paymentsTypeService = paymentTypeService;
        }

        //  [Route("GetAirports")]
        [HttpGet]
        public List<PaymentType> GetPayments()
        {
            return _paymentsTypeService.GetAll();
        }
        //    [Route("AddAirports")]
        [HttpPost]
        public void POST(PaymentType paymentType)
        {
            _paymentsTypeService.Add(paymentType);
        }
        // DELETE: api/Deleteairports
        //    [Route("Deleteairports")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var paymentType = _paymentsTypeService.GetPaymentType(id);
            _paymentsTypeService.Delete(paymentType);
        }
        // PUT: api/CountryPut
        //     [Route("EditCountry")]
        [HttpPut("{id}")]
        public void PUT(PaymentType payments)
        {

            _paymentsTypeService.Update(payments);



        }
        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public PaymentType GetPaymentsType(int id)
        {
            return _paymentsTypeService.GetPaymentType(id);
        }
    }
}