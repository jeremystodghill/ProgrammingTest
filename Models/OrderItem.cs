using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}
