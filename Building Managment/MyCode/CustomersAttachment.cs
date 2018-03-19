namespace Building_Managment.MyCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomersAttachment")]
    public partial class CustomersAttachment
    {
        [Key]
        public int Attach_ID { get; set; }

        [StringLength(150)]
        public string AttachmentName { get; set; }

        public byte[] CustomerAttachment { get; set; }

        public int? CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
