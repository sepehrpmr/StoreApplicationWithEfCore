using System.Collections.Generic;

namespace StoreApplicationWithEfCore.Models.Entiteas
{
    public class Customer
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        

    }
}
