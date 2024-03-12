namespace ZaunShop.Models.DomainModels
{
    public class OrderDetails
    {
        public int id { get; set; }

        public double total { get; set; }

        public int paymentdetailid { get; set; }
        public PaymentDetails paymentdetail { get; set; }

        public int userid { get; set; }
        public User user { get; set; }
    }
}
