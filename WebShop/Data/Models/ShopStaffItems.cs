using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Data.Models
{
    public class ShopStaffItems
    {
        public int id { get; set; }

        public Staff staff { get; set; }
        public int price { get; set; }

        public string shopStaffIf { get; set; }
    }
}
