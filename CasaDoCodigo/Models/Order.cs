using System.Collections.Generic;

namespace CasaDoCodigo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Register Register { get; set; }
        public IList<OrderItem> Items { get; set; }
    }
}