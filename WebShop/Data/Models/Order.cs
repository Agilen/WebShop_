using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Name")]
        [StringLength(15)]
        [Required(ErrorMessage = "length no more than 15")]
        public string name { get; set; }

        [Display(Name = "SurName")]
        [StringLength(15)]
        [Required(ErrorMessage = "length no more than 15")]
        public string surName { get; set; }

        [Display(Name = "Adress")]
        [StringLength(30)]
        [Required(ErrorMessage = "length no more than 30")]
        public string adress { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "length no more than 15")]
        public string phone { get; set; }

        [Display(Name = "EMail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "length no more than 30")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetail { get; set; }

    }
}
