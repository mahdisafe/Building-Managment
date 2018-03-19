namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Table()
        {
            Expenses = new HashSet<Expens>();
            Priv_Table = new HashSet<Priv_Table>();
            Purchases = new HashSet<Purchase>();
            Rents = new HashSet<Rent>();
        }

        [Key]
        public int User_ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string Username_login { get; set; }

        public string Pass_word { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public bool? UserSatatus { get; set; }

        public int? GroupID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expens> Expenses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Priv_Table> Priv_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rents { get; set; }

        public virtual UsersGroup UsersGroup { get; set; }
    }
}
