namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            PurchasesDetails = new HashSet<PurchasesDetail>();
        }

        public int PurchaseID { get; set; }

        public int? PurchasesType { get; set; }

        public int? Building_ID { get; set; }

        [StringLength(150)]
        public string Notes { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchasesDate { get; set; }

        public virtual Building Building { get; set; }

        public virtual PurchasesType PurchasesType1 { get; set; }

        public virtual User_Table User_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchasesDetail> PurchasesDetails { get; set; }
    }
}
