namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rent()
        {
            RentDetailes = new HashSet<RentDetaile>();
        }

        public int RentID { get; set; }

        public int? Pay_ID { get; set; }

        public int? CutomerID { get; set; }

        public int? MethodID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartRent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndRent { get; set; }

        public int? ShopID { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentDetaile> RentDetailes { get; set; }

        public virtual Shop Shop { get; set; }

        public virtual User_Table User_Table { get; set; }
    }
}
