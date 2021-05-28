using System;
using System.Collections.Generic;

#nullable disable

namespace EfSalesDb
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        //virtual in entity framework means the property is in the class but not in the data base
        //it is marked with virtual so entity framework knows the difference
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
