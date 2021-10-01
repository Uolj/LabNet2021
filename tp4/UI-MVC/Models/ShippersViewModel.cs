using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI_MVC.Models
{
    public class ShippersViewModel
    {
        

        [Required]
        [MaxLength (40)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(24)]
        public string PhoneNumber { get; set; }
        public int ShipperId { get; set; }
    }
}