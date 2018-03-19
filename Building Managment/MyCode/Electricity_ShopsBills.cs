namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElectricityٍShopsBills")]
    public partial class Electricity_ShopsBills
    {
        [Key]
        public int Bill_ID { get; set; }

        public int? ShopLable { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BillMonth { get; set; }

        public double? BillAmount { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
