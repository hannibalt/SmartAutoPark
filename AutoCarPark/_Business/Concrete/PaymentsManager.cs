using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
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

        public List<Payments> GetById(int PaymentId)
        {
            return _paymentsDal.GetList(l => l.PaymId == PaymentId);
        }

        public Payments GetPayments(int id)
        {
            var payments = _paymentsDal.Get(c => c.PaymId == id);
            return payments;
        }

        public bool GetPlateFromPaym(string plate)
        {
            var payt = _paymentsDal.Get(c => (c.PaymUserPlate == plate) && (c.LeftDay > 0));

            if (payt != null)
                return true;
            else
                return false;

        }

        public void Update(Payments payments)
        {
            _paymentsDal.Update(payments);
        }
    }
}
