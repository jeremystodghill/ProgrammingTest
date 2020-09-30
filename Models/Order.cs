using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest.Models
{
    class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public double OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }


}
}
