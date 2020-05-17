using _AutoParkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Abstract
{
    public interface IPaymentTypeService
    {
        List<PaymentType> GetAll();
        List<PaymentType> GetById(int paymentType);

        PaymentType GetPaymentType(int id);
        void Add(PaymentType paymentType);
        void Update(PaymentType paymentType);
        void Delete(PaymentType paymentType);
    }
}
