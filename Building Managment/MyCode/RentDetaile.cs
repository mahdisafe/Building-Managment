namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RentDetaile")]
    public partial class RentDetaile
    {
        [Key]
        public int RentDetaile_ID { get; set; }

        public int? RentID { get; set; }

        public double? Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NextMonthPay { get; set; }

        public int? MethodID { get; set; }

        public int? CreatedBy { get; set; }

        public double? RemingAmount { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual Rent Rent { get; set; }
    }
}
