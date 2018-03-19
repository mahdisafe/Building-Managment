namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Building
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Building()
        {
            Expenses = new HashSet<Expens>();
            Purchases = new HashSet<Purchase>();
            Shops = new HashSet<Shop>();
        }

        public int BuildingID { get; set; }

        [StringLength(150)]
        public string BuildingLable { get; set; }

        public int? BuildingOwner { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "image")]
        public byte[] BuildingImage { get; set; }

        public int? NumberShop { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Satete { get; set; }

        public double? ShopSize { get; set; }

        public double? insuranceAmount { get; set; }

        public double? Monthlyincome { get; set; }

        public double? Yearlyincome { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public virtual Owner Owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expens> Expenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
