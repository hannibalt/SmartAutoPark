using _AutoParkData.Models;
using System.Collections.Generic;

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
