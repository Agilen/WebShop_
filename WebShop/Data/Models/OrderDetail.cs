using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Mocks;

namespace WebShop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderId { get; set; }

        public int staffId { get; set; }

        public uint price { get; set; }

        public virtual Staff staff { get; set; }

        public virtual Order order { get; set; }
    }
}
