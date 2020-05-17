using _AutoCarPark.DataAccess.EntityFramework;
using _AutoParkData.Models;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPaymentTypeDal : EfRepositoryBase<PaymentType, AutoParkContext>, IPaymentTypeDal
    {
    }
}
