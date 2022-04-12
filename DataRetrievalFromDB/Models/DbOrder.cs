namespace DataRetrievalFromDB.Models
{
    public class DbOrder
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Fees { get; set; }
        public string OrderStatus { get; set; }
    }
}
