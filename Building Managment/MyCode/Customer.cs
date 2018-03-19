namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            CustomersAttachments = new HashSet<CustomersAttachment>();
            Rents = new HashSet<Rent>();
        }

        [Key]
        public int CutomerID { get; set; }

        [StringLength(90)]
        public string CustomerName { get; set; }

        [StringLength(90)]
        public string Email { get; set; }

        [StringLength(90)]
        public string Tel { get; set; }

        [StringLength(90)]
        public string Mobile { get; set; }

        public int? TypeID { get; set; }

        [StringLength(90)]
        public string Address { get; set; }

        [Column(TypeName = "image")]
        public byte[] CusImage { get; set; }

        [StringLength(50)]
        public string CustomerIDCard { get; set; }

        public virtual CustomerType CustomerType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersAttachment> CustomersAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
