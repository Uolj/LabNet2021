namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class Shippers
    {
        [Key]
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        public Shippers()
        {
        }
        public Shippers(string companyName, string phoneNumber)
        {
            this.CompanyName = companyName;
            this.Phone = phoneNumber;
        }
        public Shippers(int id, string companyName, string phoneNumber): this(companyName, phoneNumber)
        {
            this.ShipperID = id;
        }

       
    }
}
