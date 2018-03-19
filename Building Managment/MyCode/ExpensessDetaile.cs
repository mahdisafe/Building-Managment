namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExpensessDetaile
    {
        [Key]
        public int ExpensesDetaileID { get; set; }

        public int? Expensess_ID { get; set; }

        [StringLength(150)]
        public string ExpensessName { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public int? Qty { get; set; }

        public double? UnitPrice { get; set; }

        public double? Total { get; set; }

        public virtual Expens Expens { get; set; }
    }
}
