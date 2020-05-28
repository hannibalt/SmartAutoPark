using _AutoParkData.Models;
using System.Collections.Generic;

namespace _Business.Abstract
{
    public interface IPaymentsService
    {
        List<Payments> GetAll();
        List<Payments> GetById(int PaymentId);
        List<Payments> GetAllUnApproved(int ParkId);

        Payments GetPayments(int id);
        void Add(Payments payments);
        void Update(Payments payments);
        void Delete(Payments payments);
        int GetPlateFromPaym(string plate);
        int GetPaymentsForPlate(string plate);

    }
}
