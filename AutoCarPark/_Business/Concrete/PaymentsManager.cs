using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace _Business.Concrete
{
    public class PaymentsManager : IPaymentsService
    {
        private IPaymentsDal _paymentsDal;
        private ILogsDal _logsdal;
        public PaymentsManager(IPaymentsDal paymentsDal, ILogsDal logsDal)
        {
            _paymentsDal = paymentsDal;
            _logsdal = logsDal;
        }
        public void Add(Payments payments)
        {
            _paymentsDal.Add(payments);
        }

        public void Delete(Payments payments)
        {
            _paymentsDal.Delete(payments);
        }

        public List<Payments> GetAll()
        {
            return _paymentsDal.GetList();

        }

        public List<Payments> GetAllUnApproved(int ParkId)
        {

            return _paymentsDal.GetList(l => (l.ParkId == ParkId) && l.EventDate == Convert.ToDateTime("0001-01-01 12:00:00 AM"));

        }

        public List<Payments> GetById(int PaymentId)
        {
            return _paymentsDal.GetList(l => l.PaymId == PaymentId);
        }

        public Payments GetPayments(int id)
        {
            var payments = _paymentsDal.Get(c => c.PaymId == id);
            return payments;
        }

        public int GetPaymentsForPlate(string plate)
        {
            var payt = _paymentsDal.GetList(c => (c.PaymUserPlate.ToLower().Contains(plate.ToLower())) && c.LeftDay > 0);
            if (payt.Count != 0)
            {
                return 0;
            }
            else
                return 1;
        }

        // TO DO: düzelt burayı 
        public int GetPlateFromPaym(string plate)
        {
            var payt = _paymentsDal.GetList(c => (c.PaymUserPlate == plate.Trim()));
            for(int i = 0; i < payt.Count; i++)
            {
                if(payt[i].EventDate!= Convert.ToDateTime("0001-01-01 12:00:00 AM"))
                {
                    return 2;
                }
                
            }
            if (payt != null)
                return 1;
            else
                return 0;

        }

        public void Update(Payments payments)
        {
            _paymentsDal.Update(payments);
        }
    }
}
