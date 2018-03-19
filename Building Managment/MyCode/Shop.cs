namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop()
        {
            Electricity_ShopsBills = new HashSet<Electricity_ShopsBills>();
            Rents = new HashSet<Rent>();
        }

        public int ShopID { get; set; }

        public int? BuildingName { get; set; }

        [StringLength(50)]
        public string ShopLable { get; set; }

        [Column(TypeName = "image")]
        public byte[] ShopImage { get; set; }

        public double? LandSize { get; set; }

        public double? RentPriceForMonth { get; set; }

        public double? RentPriceForYear { get; set; }

        [StringLength(150)]
        public string Notes { get; set; }

        public double? insuranceAmount { get; set; }

        [StringLength(50)]
        public string ElectricMeterNo { get; set; }

        public virtual Building Building { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Electricity_ShopsBills> Electricity_ShopsBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
