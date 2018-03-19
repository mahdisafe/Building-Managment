namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PurchasesDetail
    {
        [Key]
        public int PurchID { get; set; }

        public int? PurchaseID { get; set; }

        [StringLength(150)]
        public string PurchesName { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public int? Qty { get; set; }

        public double? UnitPrice { get; set; }

        public double? Total { get; set; }

        public virtual Purchase Purchase { get; set; }
    }
}
