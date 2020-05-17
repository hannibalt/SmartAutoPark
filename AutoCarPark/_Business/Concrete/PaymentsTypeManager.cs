using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Concrete
{
    public class PaymentsTypeManager : IPaymentTypeService
    {
        private IPaymentTypeDal _paymentTypeDal;
        public PaymentsTypeManager(IPaymentTypeDal paymentTypeDal)
        {
            _paymentTypeDal = paymentTypeDal;
        }

        public void Add(PaymentType paymentType)
        {
            _paymentTypeDal.Add(paymentType);
        }

        public void Delete(PaymentType paymentType)
        {
            _paymentTypeDal.Delete(paymentType);
        }

        public List<PaymentType> GetAll()
        {
            return _paymentTypeDal.GetList();
        }

        public List<PaymentType> GetById(int paymentType)
        {
            return _paymentTypeDal.GetList(l => l.PaymType == paymentType);
        }

        public PaymentType GetPaymentType(int id)
        {
            var paymentType = _paymentTypeDal.Get(c => c.PaymType == id);
            return paymentType;
        }

        public void Update(PaymentType paymentType)
        {
            _paymentTypeDal.Update(paymentType);
        }
    }
}