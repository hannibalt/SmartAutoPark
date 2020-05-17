using _AutoParkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Abstract
{
    public interface IPaymentsService
    {
        List<Payments> GetAll();
        List<Payments> GetById(int PaymentId);

        Payments GetPayments(int id);
        void Add(Payments payments);
        void Update(Payments payments);
        void Delete(Payments payments);
    }
}
