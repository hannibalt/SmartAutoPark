using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Concrete
{
    public class PaymentsManager : IPaymentsService
    {
        private IPaymentsDal _paymentsDal;
        public PaymentsManager(IPaymentsDal paymentsDal)
        {
            _paymentsDal = paymentsDal;
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

        public List<Payments> GetById(int PaymentId)
        {
            return _paymentsDal.GetList(l=>l.PaymId==PaymentId);
        }

        public Payments GetPayments(int id)
        {
            var payments = _paymentsDal.Get(c => c.PaymId == id);
            return payments;
        }

        public void Update(Payments payments)
        {
            _paymentsDal.Update(payments);
        }
    }
}
