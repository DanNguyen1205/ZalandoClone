namespace ZaunShop.Models.DomainModels
{
    public class OrderItems
    {
        public int id { get; set; }

        public int quantity { get; set; }

        public double orderitemprice { get; set; }

        public int productid { get; set; }
        public Product product { get; set; }

        public int orderdetailid { get; set; }
        public OrderDetails orderdetail { get; set; }






    }
}
