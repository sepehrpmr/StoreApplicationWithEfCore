namespace StoreApplicationWithEfCore.Models.Entiteas
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public int Count { get; set; }

        public virtual Order Order { get; set; }

        public long OrderId { get; set; }

        public virtual Product Product { get; set; }
        public long ProductId { get; set; }
    }
}
