namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expenses")]
    public partial class Expens
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Expens()
        {
            ExpensessDetailes = new HashSet<ExpensessDetaile>();
        }

        [Key]
        public int Expenses_ID { get; set; }

        public int? ExpType { get; set; }

        public int? Building_ID { get; set; }

        [StringLength(150)]
        public string ExpensessDescription { get; set; }

        [StringLength(150)]
        public string Notes { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpenDate { get; set; }

        public double? Amount { get; set; }

        public virtual Building Building { get; set; }

        public virtual ExpenseType ExpenseType { get; set; }

        public virtual User_Table User_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpensessDetaile> ExpensessDetailes { get; set; }
    }
}
