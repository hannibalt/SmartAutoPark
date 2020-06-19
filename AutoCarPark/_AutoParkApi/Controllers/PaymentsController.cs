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
        IUsersService _usersService;
        public PaymentsController(IPaymentsService paymentsService, ILogsService logsService, IUsersService usersService)
        {
            _paymentsService = paymentsService;
            _logservice = logsService;
            _usersService = usersService;
        }


        [HttpGet]
        public List<Payments> GetPaymentsAll()
        {
            return _paymentsService.GetAll();
        }

        [HttpGet("ParkId")]
        public List<Payments> GetUnApproved(int ParkId)
        {
            return _paymentsService.GetAllUnApproved(ParkId);
        }
        [HttpPost]
        public void POST(Payments payments)
        {
            _paymentsService.Add(payments);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var payments = _paymentsService.GetPayments(id);
            _paymentsService.Delete(payments);
        }
        [HttpPut]
        public void PUT(Payments pay)
        {
            _paymentsService.Update(pay);

        }
        //[HttpPut("{id}")]
        //public void PUT(Payments pay)
        //{
        //    _paymentsService.Update(pay);
        //}

        // GET: api/Country/5
        //      [Route("GetByIdAirports")]
        [HttpGet("{id}")]
        public Payments GetPayment(int id)
        {
            return _paymentsService.GetPayments(id);
        }

        [HttpPost("payments")]
        public int GetPaymentsForPlate(Payments payments)
        {
            var result = _paymentsService.GetPaymentsForPlate(payments.PaymUserPlate);
            if (result == 0)
            {
                return 0;


            }
            else
                return 1;

        }

        [HttpPost("logs")]
        public int GetPayments(Logs logs)
        {
            var result = _paymentsService.GetPlateFromPaym(logs.SubPlate);
            if (result == 2)
            {
                var userinfo = _usersService.GetByCarPlate(logs.SubPlate);

                if (userinfo.UseActive == true)
                {
                    _logservice.Add(logs);

                }
                else
                    return 0;

            }
            else
                return 0;


            return result;
        }


    }
}