using _AutoCarPark.Entities;

namespace _AutoParkData.Models
{
    public partial class PaymentType : IEntity
    {
        public int PaymType { get; set; }
        public decimal? PaymtQuantity { get; set; }
        public int? PaymtValidity { get; set; }
    }
}
