namespace StoreApplicationWithEfCore.Models.Entiteas
{
    public class Warranty
    {

        public Product Product { get; set; }
        public long ProductId { get; set; }
        public int WarrantyPeriod { get; set; }
    }
}
